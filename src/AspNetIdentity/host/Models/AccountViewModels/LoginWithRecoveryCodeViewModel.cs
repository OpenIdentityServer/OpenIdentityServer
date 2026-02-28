// SPDX-License-Identifier: Apache-2.0

using System.ComponentModel.DataAnnotations;

namespace OpenIdentityServer.Models.AccountViewModels
{
    public class LoginWithRecoveryCodeViewModel
    {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Recovery Code")]
            public string RecoveryCode { get; set; }
    }
}
