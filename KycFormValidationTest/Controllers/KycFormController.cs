using KycFormValidationTest.EdiModels;
using KycFormValidationTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KycFormValidationTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KycFormController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("kyc-forms/corporate")]
        public async Task<IActionResult> SaveCorporateUserForm([FromBody] CorporateFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var saveCorporateFormRequest = (SaveCorporateFormRequest)model;
            // await _kycFormService.SaveCorporateUserFormAsync(formId, saveCorporateFormRequest);

            return Ok();
        }

        [HttpPost("kyc-forms/private")]
        public async Task<IActionResult> SavePrivateUserForm([FromBody] PrivateFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var savePrivateFormRequest = (SavePrivateFormRequest)model;
            // await _kycFormService.SavePrivateUserFormAsync(formId, savePrivateFormRequest);

            return Ok();
        }
    }
}
