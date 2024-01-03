using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;

namespace Highlighter
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [ProvideAutoLoad(VSConstants.UICONTEXT.ShellInitialized_string, PackageAutoLoadFlags.BackgroundLoad)]
    [Guid(PackageGuidString)]
    public sealed class HighlighterPackage : AsyncPackage
    {
        public const string PackageGuidString = "2ae76b66-222f-4f34-8d9f-1fb384433dfb";

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            Project._package = this;

            await base.InitializeAsync(cancellationToken, progress);
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        }
    }

    internal static class Project
    {
        internal static Package _package;
    }
}