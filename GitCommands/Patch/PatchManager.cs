using GitCommands.Settings;
            if (body != null && module.EffectiveConfigFile.core.autocrlf.Value == AutoCRLFType.True)
            if (reset && body != null && module.EffectiveConfigFile.core.autocrlf.Value == AutoCRLFType.True)
                result = result.Combine("\n", Application.ProductName + " " + AppSettings.ProductVersion);