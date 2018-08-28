// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using Microsoft.VisualStudio.LanguageServices.Implementation.ProjectSystem.Interop;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.ProjectSystem.Legacy
{
    internal abstract partial class AbstractLegacyProject : IAnalyzerHost
    {
        void IAnalyzerHost.AddAnalyzerReference(string analyzerAssemblyFullPath)
        {
            VisualStudioProject.AddAnalyzerReference(analyzerAssemblyFullPath);
        }

        void IAnalyzerHost.RemoveAnalyzerReference(string analyzerAssemblyFullPath)
        {
            VisualStudioProject.RemoveAnalyzerReference(analyzerAssemblyFullPath);
        }

        void IAnalyzerHost.SetRuleSetFile(string ruleSetFileFullPath)
        {
            VisualStudioProjectOptionsProcessor.ExplicitRuleSetFilePath = ruleSetFileFullPath;
        }

        void IAnalyzerHost.AddAdditionalFile(string additionalFilePath)
        {
            VisualStudioProject.AddAdditionalFile(additionalFilePath);
        }

        void IAnalyzerHost.RemoveAdditionalFile(string additionalFilePath)
        {
            VisualStudioProject.RemoveAdditionalFile(additionalFilePath);
        }
    }
}
