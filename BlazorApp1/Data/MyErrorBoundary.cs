using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp1.Data;

public class MyErrorBoundary : ErrorBoundary
{
    public new Exception? CurrentException => base.CurrentException;
}