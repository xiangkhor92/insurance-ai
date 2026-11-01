using System;
using System.Diagnostics;
using System.Windows.Forms;

// Opens the Insurance AI app in the default browser, where the user is already signed in to Claude.
static class InsuranceAI
{
    const string AppUrl = "https://claude.ai/artifact/MxsF59325xje22TfX2yjXX";

    [STAThread]
    static void Main()
    {
        try
        {
            Process.Start(new ProcessStartInfo(AppUrl) { UseShellExecute = true });
        }
        catch (Exception)
        {
            MessageBox.Show("Couldn't open your browser. Open this link instead:\n\n" + AppUrl,
                "Insurance AI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
