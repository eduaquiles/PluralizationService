﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Aquiles.PluralizationService.Infrastructure.Pluralization
{
    using System;
    using Xunit;

    public class EnglishPluralizationServiceTests
    {
        [Fact]
        public void Ctor_should_throw_when_user_dictionary_entries_is_null()
        {
            Assert.Equal(
                "userDictionaryEntries",
                (Assert.Throws<ArgumentNullException>(() => new EnglishPluralizationService(null))).ParamName);
        }

        [Fact]
        public void Singularize_userdictionary_override_default_rules()
        {
            var entries = new[]
                              {
                                  new CustomPluralizationEntry(singular: "X", plural: "Z")
                              };
            var pluralizationService = new EnglishPluralizationService(entries);

            Assert.Equal("X", pluralizationService.Singularize("Z"));
        }

        [Fact]
        public void Pluralize_userdictionary_override_default_rules()
        {
            var entries = new[]
                              {
                                  new CustomPluralizationEntry(singular: "X", plural: "Z")
                              };
            var pluralizationService = new EnglishPluralizationService(entries);

            Assert.Equal("Z", pluralizationService.Pluralize("X"));
        }
    }
}
