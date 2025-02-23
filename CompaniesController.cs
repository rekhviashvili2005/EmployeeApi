using API111.DTOs;
using API111.Services;
using Microsoft.AspNetCore.Mvc;

namespace API111.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]//1111111
    public class CompaniesController : ControllerBase
    {

        private readonly ICompaniesService _companiesService;

        public CompaniesController(ICompaniesService companiesService)
        {
            _companiesService = companiesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _companiesService.GetAllCompaniesAsync();

            return Ok(companies);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetCompanyById(Guid id)
        {
            var company = await _companiesService.GetCompanyByIdAsync(id);
            if (company == null) NotFound();

            return Ok(company);
        }


        [HttpGet]
        [Route("Details/{id:guid}")]
        public async Task<IActionResult> GetCompanyDetailsById(Guid id)
        {
            var company = await _companiesService.GetCompanyDetailsByIdAsync(id);
            if (company == null) NotFound();

            return Ok(company);
        }


        [HttpPost]
        [Route("Add")]
        //api/Companies/AddCompany?id=
        public async Task<IActionResult> AddCompany(CreateCompanyDto createCompanyDto)
        {
            await _companiesService.AddCompanyAsync(createCompanyDto);
            return Ok();
        }

        [HttpPut]
        [Route("update/{id:guid}")]
        //api/Companies/UpdateCompany?id=
        public async Task<IActionResult> UpdateCompany(Guid id, UpdateCompanyDto updateCompanyDto)
        {
            var company = await _companiesService.UpdateCompanyAsync(id, updateCompanyDto);
            return Ok(company);
        }

        [HttpDelete]
        [Route("delete/{id:guid}")]
        //api/Employees/UpdateEmployee?id=
        public async Task<IActionResult> DeleteCompany(Guid id)
        {
            await _companiesService.DeleteCompanyByIdAsync(id);
            return Ok();
        }

    }
}
