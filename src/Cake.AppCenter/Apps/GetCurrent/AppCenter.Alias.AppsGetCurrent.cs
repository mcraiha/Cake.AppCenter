using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Get the application that's set as default for all CLI commands
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterAppsGetCurrent(this ICakeContext context, AppCenterAppsGetCurrentSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAppsGetCurrentSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apps get-current", settings ?? new AppCenterAppsGetCurrentSettings(), arguments);
		}
	}
}