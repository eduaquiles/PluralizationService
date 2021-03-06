﻿// <auto-generated />

namespace Aquiles.PluralizationService.Properties.Resources
{
    using System;
	using System.CodeDom.Compiler;
    using System.Globalization;
    using System.Resources;
    using System.Threading;

    /// <summary>
    ///     Strongly-typed and parameterized string resources.
    /// </summary>
    [GeneratedCode("Resources.tt", "1.0.0.0")]
    public static class Strings
    {
        /// <summary>
        ///     A string like "The argument '{0}' cannot be null, empty or contain only white space."
        /// </summary>
        public static string ArgumentIsNullOrWhitespace(object p0)
        {
            return EntityRes.GetString(EntityRes.ArgumentIsNullOrWhitespace, p0);
        }
    }

    /// <summary>
    ///     Strongly-typed and parameterized exception factory.
    /// </summary>
    [GeneratedCode("Resources.tt", "1.0.0.0")]
    internal static class Error
    {    }

    /// <summary>
    ///     AutoGenerated resource class. Usage:
    ///     string s = EntityRes.GetString(EntityRes.MyIdenfitier);
    /// </summary>
    [GeneratedCode("Resources.tt", "1.0.0.0")]
    internal sealed class EntityRes
    {
        internal const string ArgumentIsNullOrWhitespace = "ArgumentIsNullOrWhitespace";

        private static EntityRes loader;
        private readonly ResourceManager resources;

        private EntityRes()
        {
            resources = new ResourceManager(
                "Aquiles.PluralizationService.Properties.Resources", typeof(Infrastructure.Pluralization.IPluralizationService).Assembly);
        }

        private static EntityRes GetLoader()
        {
            if (loader == null)
            {
                var sr = new EntityRes();
                Interlocked.CompareExchange(ref loader, sr, null);
            }
            return loader;
        }

        private static CultureInfo Culture
        {
            get { return null /*use ResourceManager default, CultureInfo.CurrentUICulture*/; }
        }

        public static ResourceManager Resources
        {
            get { return GetLoader().resources; }
        }

        public static string GetString(string name, params object[] args)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }

            var res = sys.resources.GetString(name, Culture);

            if (args != null
                && args.Length > 0)
            {
                for (var i = 0; i < args.Length; i ++)
                {
                    var value = args[i] as String;
                    if (value != null
                        && value.Length > 1024)
                    {
                        args[i] = value.Substring(0, 1024 - 3) + "...";
                    }
                }
                return String.Format(CultureInfo.CurrentCulture, res, args);
            }
            else
            {
                return res;
            }
        }

        public static string GetString(string name)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }
            return sys.resources.GetString(name, Culture);
        }

        public static string GetString(string name, out bool usedFallback)
        {
            // always false for this version of gensr
            usedFallback = false;
            return GetString(name);
        }

        public static object GetObject(string name)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }
            return sys.resources.GetObject(name, Culture);
        }
    }
}
