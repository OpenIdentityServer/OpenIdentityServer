// SPDX-License-Identifier: Apache-2.0

using System.ComponentModel.DataAnnotations;

namespace OpenIdentityServer.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
