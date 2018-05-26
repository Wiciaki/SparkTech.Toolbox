namespace SparkTech.Toolbox.Admin
{
    using System.Security.Principal;

    public static class AdminUtils
    {
        public static bool IsProcessElevated()
        {
            var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}