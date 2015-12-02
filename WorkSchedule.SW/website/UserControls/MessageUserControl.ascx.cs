using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Entity.Validation;
using EatIn.UI;
public partial class UserControls_MessageUserControl : System.Web.UI.UserControl
{
    #region String Constants
    private const string STR_TITLE_GeneralErrors = "Processing Error";
    private const string STR_TEXT_GeneralErrors = "Unable to process your submission due to the following reason(s).";
    private const string STR_TITLE_ValidationErrors = "Validation Errors";
    private const string STR_TEXT_ValidationErrors = "Validation errors encountered with your submission.";
    private const string STR_TITLE_UsageInstructions = "Usage Instructions";
    private const string STR_TITLE_ICON_warning = "glyphicon glyphicon-warning-sign";
    private const string STR_PANEL_danger = "panel panel-danger";
    private const string STR_TITLE_ICON_info = "glyphicon glyphicon-info-sign";
    private const string STR_PANEL_info = "panel panel-info";
    private const string STR_TITLE_ICON_success = "glyphicon glyphicon-ok-sign";
    private const string STR_PANEL_success = "panel panel-success";
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        MessagePanel.Visible = false;
    }

    public void ShowInfo(string message)
    {
        ShowInfo(STR_TITLE_UsageInstructions, message);
    }

    public void ShowInfo(string title, string message)
    {
        ShowInfo(message, title, STR_TITLE_ICON_info, STR_PANEL_info);
    }

    public void TryRun(ProcessRequest callback)
    {
        TryCatch(callback);
    }

    public void TryRun(ProcessRequest callback, string title, string successMessage)
    {
        if (TryCatch(callback))
            ShowInfo(successMessage, title, STR_TITLE_ICON_success, STR_PANEL_success);
    }

    public void HandleDataBoundException(ObjectDataSourceStatusEventArgs e)
    {
        if (e.Exception is DbEntityValidationException)
        {
            HandleException(e.Exception as DbEntityValidationException);
            e.ExceptionHandled = true;
        }
        else if (e.Exception is Exception)
        {
            HandleException(e.Exception as Exception);
            e.ExceptionHandled = true;
        }
    }

    private bool TryCatch(ProcessRequest callback)
    {
        try
        {
            callback();
            return true;
        }
        catch (DbEntityValidationException ex)
        {
            HandleException(ex);
        }
        catch (Exception ex)
        {
            HandleException(ex);
        }
        return false;
    }

    private void HandleException(DbEntityValidationException ex)
    {
        var details = from DbValidationError error in ex.EntityValidationErrors.First().ValidationErrors
                      select new
                      {
                          Error = error.ErrorMessage
                      };
        ShowExceptions(details, STR_TEXT_ValidationErrors, STR_TITLE_ValidationErrors, STR_TITLE_ICON_warning, STR_PANEL_danger);
    }

    private void HandleException(Exception ex)
    {
        Exception root = ex;
        while (root.InnerException != null)
            root = root.InnerException;
        if (root is DbEntityValidationException)
            HandleException(root as DbEntityValidationException);
        else
        {
            dynamic[] details = new dynamic[] { new { Error = root.Message } };
            ShowExceptions(details, STR_TEXT_GeneralErrors, STR_TITLE_GeneralErrors, STR_TITLE_ICON_warning, STR_PANEL_danger);
        }
    }

    private void ShowExceptions(object details, string messageText, string messageTitle, string titleIcon, string panelClass)
    {
        MessageDetailsRepeater.DataSource = details;
        MessageDetailsRepeater.DataBind();
        ShowInfo(messageText, messageTitle, titleIcon, panelClass);
    }

    private void ShowInfo(string messageText, string messageTitle, string titleIcon, string panelClass)
    {
        MessageLabel.Text = messageText;
        MessageTitle.Text = messageTitle;
        MessageTitleIcon.CssClass = titleIcon;
        MessagePanel.CssClass = panelClass;
        MessagePanel.Visible = true;
    }
}