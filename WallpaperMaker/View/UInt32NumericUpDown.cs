using System;
using System.Media;
using System.Windows.Forms;

namespace WallpaperMaker.View
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
			private Control mListenerControl = null;

			private Form mParentForm = null;

			// From WinUser.h
			private const int WM_PASTE = 0x0302;

			public decimal Maximum { get; set; }

			public decimal Minimum { get; set; }

			public int SelectionLength
			{
				get
				{
					return ((TextBox)mListenerControl).SelectionLength;
				}
			}

			public int SelectionStart
			{
				get
				{
					return ((TextBox)mListenerControl).SelectionStart;
				}
			}

			/// <summary>
			/// Allows WndProc monitoring without needing to subclass the control.
			/// </summary>
			/// <param name="editControl">Control which needs WndProc override.</param>
			public NativeWindowListener(Control editControl) : base()
			{
				AssignHandle(editControl.Handle);

				mListenerControl = editControl;
				UInt32NumericUpDown owner = (UInt32NumericUpDown)editControl.Parent;
				mParentForm = owner.FindForm();
				if(mParentForm != null)
					mParentForm.FormClosed += new FormClosedEventHandler(ParentForm_Closed);
			}

			private void ParentForm_Closed(object sender, EventArgs e)
			{
				mParentForm.FormClosed -= new FormClosedEventHandler(ParentForm_Closed);
				ReleaseHandle();
			}


			protected override void WndProc(ref Message m)
			{
				switch(m.Msg)
				{
					case WM_PASTE:
						string text = Clipboard.GetText();
						if(string.IsNullOrEmpty(text))
						{
							SystemSounds.Beep.Play();
							return;
						}

						uint i;
						if(!uint.TryParse(text, out i))
						{
							SystemSounds.Beep.Play();
							return;
						}

						// want to enforce that resulting paste results in positive number
						int selectionStart = this.SelectionStart;
						int selectionLength = this.SelectionLength;
						string oldValue = ((TextBox)mListenerControl).Text;
						string newValue = oldValue.Substring(0, selectionStart) + text + oldValue.Substring(selectionStart + selectionLength);
						ulong j;
						if(!ulong.TryParse(newValue, out j) || j < this.Minimum || j > this.Maximum)
						{
							SystemSounds.Beep.Play();
							return;
						}

						break;
				}

				base.WndProc(ref m);
			}
		}

		#endregion Classes

		#region Fields

		private NativeWindowListener mPasteListener = null;

		#endregion Fields

		#region Methods

		public UInt32NumericUpDown()
		{
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			// delete (OnKeyPress does not capture del key)
			if(e.KeyData == Keys.Delete)
			{
				int selectionStart = mPasteListener.SelectionStart;
				string oldValue = this.Text;
				if(selectionStart < oldValue.Length)
				{
					int selectionLength = mPasteListener.SelectionLength;
					string newValue;
					if(selectionLength > 0)
						newValue = oldValue.Substring(0, selectionStart) + oldValue.Substring(selectionStart + selectionLength);
					else
						newValue = oldValue.Substring(0, selectionStart) + oldValue.Substring(selectionStart + 1);

					ulong j;
					if(ulong.TryParse(newValue, out j) && j >= this.Minimum && j < this.Maximum)
					{
						return;
					}
				}

				SystemSounds.Beep.Play();
				e.Handled = true;
			}
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);

			string c = e.KeyChar.ToString();

			if(char.IsDigit(c, 0))
			{
				int selectionStart = mPasteListener.SelectionStart;
				int selectionLength = mPasteListener.SelectionLength;
				string oldValue = this.Text;
				string newValue = oldValue.Substring(0, selectionStart) + c + oldValue.Substring(selectionStart + selectionLength);

				ulong j;
				if(ulong.TryParse(newValue, out j) && j >= this.Minimum && j < this.Maximum)
				{
					return;
				}
			}

			// cut/copy/paste
			if((((int)e.KeyChar == 24) || ((int)e.KeyChar == 3) || ((int)e.KeyChar == 22))
				&& ((ModifierKeys & Keys.Control) == Keys.Control))
				return;

			// enter/new line
			if(((int)e.KeyChar == '\r') || ((int)e.KeyChar == '\n'))
				return;

			// backspace
			if(e.KeyChar == '\b')
			{
				int selectionStart = mPasteListener.SelectionStart;
				if(selectionStart > 0)
				{
					int selectionLength = mPasteListener.SelectionLength;
					string oldValue = this.Text;
					string newValue;
					if(selectionLength > 0)
						newValue = oldValue.Substring(0, selectionStart) + oldValue.Substring(selectionStart + selectionLength);
					else
						newValue = oldValue.Substring(0, selectionStart - 1) + oldValue.Substring(selectionStart);

					ulong j;
					if(ulong.TryParse(newValue, out j) && j >= this.Minimum && j < this.Maximum)
					{
						return;
					}
				}
			}

			// Normal NumericUpDown won't allow select all. We will provide that functionality here.
			if(((int)e.KeyChar == 1) && ((ModifierKeys & Keys.Control) == Keys.Control))
			{
				((TextBox)this.Controls[1]).SelectAll();
			}
			// Handle all bad keypresses here
			else
				SystemSounds.Beep.Play();

			e.Handled = true;
		}

		// Needed an event that happens after the form is fully initialized.
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);

			// Extract a reference to the underlying textbox edit field so we can trap the context menu paste click.
			mPasteListener = new NativeWindowListener((TextBox)this.Controls[1]);
			mPasteListener.Minimum = this.Minimum;
			mPasteListener.Maximum = this.Maximum;
		}

		#endregion Methods
	}
}
