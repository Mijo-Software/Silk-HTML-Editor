using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Silk_HTML_Editor
{
  public partial class SilkHtmlEditorForm : Form
  {
    public SilkHtmlEditorForm()
    {
      InitializeComponent();
    }

    private void tsmiExitApp_Click(object sender, EventArgs e)
    {
      string message = "Wollen Sie das Programm wirklich beenden?";
      string caption = "Programm beenden";
      MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result;
      MessageBoxIcon icon = MessageBoxIcon.Question;
      result = MessageBox.Show(message,caption,buttons,icon);
      if (result == DialogResult.Yes)
      {
        this.Close();
      }
    }
  }
}
