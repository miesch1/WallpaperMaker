using System;
using System.Globalization;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace WindowsApplication1
{
	/// <summary>
	///   Adapted from http://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers and
	///   http://social.msdn.microsoft.com/Forums/eu/csharpgeneral/thread/84cb8f20-eacc-4aa2-93d0-941e4178e0e5
	/// </summary>
	public class UInt32NumericUpDown : NumericUpDown
	{
		#region Classes

		private class NativeWindowListener : NativeWindow
		{
			private Form parent_form = null;
			private Control listener_control = null;
			private UInt32NumericUpDown owner = null;

			public bool ContextMenuIsDropped { get; set; }

			// From WinUser.h
			private const int EM_UNDO = 0x00C7;
			private const int WM_CUT = 0x0300;
			private const int WM_COPY = 0x0301;
			private const int WM_PASTE = 0x0302;
			private const int WM_CONTEXTMENU = 0x007B;

			/// <summary>
			/// Allows WndProc monitoring without needing to subclass the control.
			/// </summary>
			/// <param name="editControl">Control which needs WndProc override.</param>
			public NativeWindowListener(Control editControl) : base()
			{
				AssignHandle(editControl.Handle);

				owner = (UInt32NumericUpDown)editControl.Parent;
				parent_form = owner.FindForm();
				listener_control = editControl;
				if(parent_form != null)
					parent_form.FormClosed += new FormClosedEventHandler(ParentForm_Closed);

				ContextMenuIsDropped = false;
			}

			private void ParentForm_Closed(object sender, EventArgs e)
			{
				parent_form.FormClosed -= new FormClosedEventHandler(ParentForm_Closed);
				ReleaseHandle();
			}

			protected override void WndProc(ref Message m)
			{
				switch(m.Msg)
				{
					case WM_CONTEXTMENU:
						ContextMenuIsDropped = true;
						break;
					case WM_PASTE:
						// Must check ContextMenuIsDropped because keyboard paste also sends this message.
						if(ContextMenuIsDropped)
						{
							ContextMenuIsDropped = false;
							//owner.ContextMenuPaste = true;
						}

						string text = Clipboard.GetText();
						if(string.IsNullOrEmpty(text))
							return;

						if((text.IndexOf('+') >= 0) && (((TextBox)listener_control).SelectionStart != 0))
							return;

						uint i;
						if(!uint.TryParse(text, out i)) // change this for other integer types
							return;

						if((i < 0) && (((TextBox)listener_control).SelectionStart != 0))
							return;
						break;
				}

				base.WndProc(ref m);
			}
		}

		#endregion Classes

		#region Fields

		NativeWindowListener context_menu_listener = null;

		#endregion Fields

		#region Methods

		public UInt32NumericUpDown()
		{
			Minimum = 0;
			Maximum = UInt32.MaxValue;
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);

			string c = e.KeyChar.ToString();
			if(char.IsDigit(c, 0))
				return;

			// cut/copy/paste
			if((((int)e.KeyChar == 24) || ((int)e.KeyChar == 3) || ((int)e.KeyChar == 22))
				&& ((ModifierKeys & Keys.Control) == Keys.Control))
				return;

			// backspace
			if(e.KeyChar == '\b')
				return;

			// Normal NumericUpDown won't allow select all. We will provide that functionality here.
			if(((int)e.KeyChar == 1) && ((ModifierKeys & Keys.Control) == Keys.Control))
				((TextBox)this.Controls[1]).SelectAll();
			// Handle all bad keypresses here
			else
				SystemSounds.Beep.Play();

			e.Handled = true;
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			// Reset if user clicked outside the context menu to close it.
			this.context_menu_listener.ContextMenuIsDropped = false;
		}


		// Needed an event that happens after the form is fully initialized.
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);

			// Extract a reference to the underlying textbox edit field so we can trap the context menu paste click.
			context_menu_listener = new NativeWindowListener((TextBox)this.Controls[1]);
		}

		//protected override void WndProc(ref System.Windows.Forms.Message m)
		//{
		//    if(m.Msg == WM_PASTE)
		//    {
		//        string text = Clipboard.GetText();
		//        if(string.IsNullOrEmpty(text))
		//            return;

		//        if((text.IndexOf('+') >= 0) && (((TextBox)this.Controls[1]).SelectionStart != 0))
		//            return;

		//        uint i;
		//        if(!uint.TryParse(text, out i)) // change this for other integer types
		//            return;

		//        if((i < 0) && (((TextBox)this.Controls[1]).SelectionStart != 0))
		//            return;
		//    }

		//    base.WndProc(ref m);
		//}

		#endregion Methods
	}
}
