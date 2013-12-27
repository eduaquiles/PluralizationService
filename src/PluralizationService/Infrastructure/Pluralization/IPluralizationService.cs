// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Aquiles.PluralizationService.Infrastructure.Pluralization
{
    /// <summary>
    ///     Pluralization services to be used by the EF runtime implement this interface.
    ///     By default the <see cref="EnglishPluralizationService" /> is used, but the pluralization service to use
    ///     can be set in a class derived.
    /// </summary>
    public interface IPluralizationService
    {
        /// <summary>
        ///     Pluralize a word using the service.
        /// </summary>
        /// <param name="word">The word to pluralize.</param>
        /// <returns>The pluralized word </returns>
        string Pluralize(string word);

        /// <summary>
        ///     Singularize a word using the service.
        /// </summary>
        /// <param name="word">The word to singularize.</param>
        /// <returns>The singularized word.</returns>
        string Singularize(string word);
    }
}
