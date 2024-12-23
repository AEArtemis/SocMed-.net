using DataManager;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class ThemeManager
{
    public static event Action<string> onThemeChanged;
    private static string _currentTheme; // No default value

    // Expose the current theme
    public static string CurrentTheme => _currentTheme;

    // Define colors for Guna UI controls
    private static Color _gunaCircleButtonFillColor;
    private static Color _gunaPanelFillColor;
    private static Color _formBackColor;
    private static Color _pnlMainBGColor;

    public static async Task InitializeUIAsync(Form form, int userId)
    {
        try
        {
            // Fetch the theme from the database if not already set
            if (string.IsNullOrEmpty(_currentTheme))
            {
                _currentTheme = await GetThemeFromDatabaseAsync(userId) ?? "light"; // Default to light if null
            }

            ApplyThemeBasedOnCurrentTheme(form, _currentTheme);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error initializing UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task ToggleThemeAsync(int userId)
    {
        try
        {
            _currentTheme = _currentTheme == "light" ? "dark" : "light";
            await SetThemeInDatabaseAsync(userId, _currentTheme);
            onThemeChanged?.Invoke(_currentTheme); // Notify listeners
            ApplyThemeToOpenForms(); // Apply theme to all open forms
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error toggling theme: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task ApplyCurrentThemeAsync(Form form, int userId)
    {
        await InitializeUIAsync(form, userId);
    }

    private static void ApplyThemeBasedOnCurrentTheme(Form form, string currentTheme)
    {
        if (currentTheme == "light")
        {
            _gunaCircleButtonFillColor = Color.FromArgb(242, 242, 249);
            _gunaPanelFillColor = Color.White;
            _formBackColor = Color.FromArgb(242, 242, 249);
            _pnlMainBGColor = Color.FromArgb(242, 242, 249); // Light theme color for pnlMainBG
        }
        else
        {
            _gunaCircleButtonFillColor = Color.FromArgb(94, 94, 94);
            _gunaPanelFillColor = Color.FromArgb(26, 26, 26);
            _formBackColor = Color.FromArgb(23, 23, 23);
            _pnlMainBGColor = Color.FromArgb(23, 23, 23); // Dark theme color for pnlMainBG
        }

        ApplyThemeToForm(form);
    }

    private static async Task<string> GetThemeFromDatabaseAsync(int userId)
    {
        return await Task.Run(() =>
        {
            string theme = "light"; // Default to light in case of any issues
            DataResultSet m_set = new DataResultSet();

            m_set.Query = "SELECT theme FROM users WHERE user_id = @UserID";
            m_set.AddParameter("@UserID", userId);

            if (m_set.Execute() && m_set.Read())
            {
                theme = m_set.GetString(0);
                if (string.IsNullOrEmpty(theme)) // Handle empty or null theme from database
                {
                    theme = "light";
                }
            }
            m_set.Close();
            return theme;
        });
    }

    private static async Task SetThemeInDatabaseAsync(int userId, string newTheme)
    {
        await Task.Run(() =>
        {
            DataResultSet m_set = new DataResultSet();
            m_set.Query = "UPDATE users SET theme = @Theme WHERE user_id = @UserID";
            m_set.AddParameter("@UserID", userId);
            m_set.AddParameter("@Theme", newTheme);

            m_set.Execute();
            m_set.Close();
        });
    }

    private static void ApplyThemeToForm(Form form)
    {
        form.BackColor = _formBackColor; 
        foreach (Control control in form.Controls)
        {
            ApplyThemeToControl(control);
        }
    }

    private static void ApplyThemeToControl(Control control)
    {
        control.BackColor = _currentTheme == "light" ? Color.FromArgb(242, 242, 249) : Color.FromArgb(23, 23, 23);
        control.ForeColor = _currentTheme == "light" ? Color.FromArgb(26, 26, 26) : Color.FromArgb(242, 242, 249);
        if (control is Guna.UI2.WinForms.Guna2Panel gunaPanel)
        {
            if (control.Name == "pnlMainBG")
            {
                gunaPanel.FillColor = _pnlMainBGColor; 
            }
            else
            {

                gunaPanel.FillColor = _currentTheme == "light" ? Color.White : Color.FromArgb(34, 34, 34);
            }
        }
        else if (control is Guna.UI2.WinForms.Guna2CustomGradientPanel gunaPanelCustomGradient)
        {
            gunaPanelCustomGradient.FillColor = _currentTheme == "light" ? Color.White : Color.FromArgb(34, 34, 34);
            gunaPanelCustomGradient.FillColor2 = _currentTheme == "light" ? Color.White : Color.FromArgb(34, 34, 34);
            gunaPanelCustomGradient.FillColor3 = _currentTheme == "light" ? Color.White : Color.FromArgb(34, 34, 34);
            gunaPanelCustomGradient.FillColor4 = _currentTheme == "light" ? Color.White : Color.FromArgb(34, 34, 34);
        }
        else if (control is Guna.UI2.WinForms.Guna2Button gunaButton)
        {

            gunaButton.FillColor = Color.Transparent;
            gunaButton.BackColor = Color.Transparent;
        }

        else if (control is Guna.UI2.WinForms.Guna2CircleButton gunaCircleButton)
        {
            gunaCircleButton.FillColor = _currentTheme == "light" ? Color.FromArgb(242, 242, 249) : Color.FromArgb(94, 94, 94);
            gunaCircleButton.BackColor = Color.Transparent;
        }
        else if (control is Guna.UI2.WinForms.Guna2HtmlLabel gunaLabel)
        {
            gunaLabel.BackColor = Color.Transparent;
            gunaLabel.ForeColor = _currentTheme == "light" ? Color.FromArgb(26, 26, 26) : Color.White;
        }
        else if (control is Guna.UI2.WinForms.Guna2TextBox gunaTextbox)
        {
            gunaTextbox.BackColor = Color.Transparent;
            gunaTextbox.FillColor = _currentTheme == "light" ? Color.White : Color.FromArgb(94, 94, 94);
            gunaTextbox.ForeColor = _currentTheme == "light" ? Color.FromArgb(26, 26, 26) : Color.White;
        }
        else if (control is Guna.UI2.WinForms.Guna2CirclePictureBox gunaCirclePicture)
        {

        }
        else if (control is FlowLayoutPanel flowLayoutPanel)
        {
            control.BackColor = _currentTheme == "light" ? Color.Transparent : Color.Transparent;
        }


        foreach (Control child in control.Controls)
        {
            ApplyThemeToControl(child);
        }
    }

    public static void ApplyThemeToOpenForms()
    {
        foreach (Form form in Application.OpenForms)
        {
            ApplyThemeToForm(form);
        }
    }
}
