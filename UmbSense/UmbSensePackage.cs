using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace UmbSense
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(UmbSensePackage.PackageGuidString)]
    public sealed class UmbSensePackage : AsyncPackage
    {
        /// <summary>
        /// UmbSensePackage GUID string.
        /// </summary>
        public const string PackageGuidString = "0d2a97ed-6cd5-442d-a213-7b881f8f2b49";

        #region Package Members

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            // When initialized asynchronously, the current thread may be a background thread at this point.
            // Do any initialization that requires the UI thread after switching to the UI thread.
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        }

        #endregion
    }
}
