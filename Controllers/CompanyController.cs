using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using inProject.Models;
using inProject.Models.Domain;
using inProject.Data;
using inProject.Services.Interface;
using inProject.Repositores.Interface;
using Microsoft.AspNetCore.Identity;
using AspNetCoreHero.ToastNotification.Abstractions;
using inProject.ViewModels.CompanyVM;
using inProject.Dtos.CompanyDto;

namespace inProject.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly ICompanyRepository _companyRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly INotyfService _notyfService;

        public CompanyController(ICompanyService companyService, ICompanyRepository companyRepository, UserManager<ApplicationUser> userManager, INotyfService notyfService)
        {
            _companyService = companyService;
            _companyRepository = companyRepository;
            _userManager = userManager;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _companyRepository.GetAllCompanies();
            var vm = companies.Select(x => new CompanyVM()
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
            }).ToList();
            return View(vm);
        }
        public async Task<IActionResult> Create()
        {
            var vm = new CreateCompanyVM();
            return PartialView("_AddCompanyPartialView", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCompanyVM vm)
        {
            if(!ModelState.IsValid) return View(vm);
            try
            {
                var dto = new CreateCompanyDto()
                {
                    CompanyName = vm.CompanyName
                };
                await _companyService.CreateAsync(dto);
                _notyfService.Success("Company created successfuly");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _notyfService.Error(ex.Message);
                return View(vm);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _companyService.DeleteAsync(id);
                _notyfService.Success("Company deleted successfully");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _notyfService.Error(ex.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var company = await _companyRepository.GetByAsync(x => x.Id == id);
                var vm = new EditCompanyVM()
                {
                    Id=company.Id,
                    CompanyName=company.CompanyName
                };
                return View(vm);
            }
            catch (Exception ex)
            {
                _notyfService.Error(ex.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> Edit(EditCompanyVM vm)
        {
            if(!ModelState.IsValid) return View(vm);
            var currentUser=await _userManager.GetUserAsync(User);
            try
            {
                var dto = new UpdateCompanyDto()
                {
                    Id= vm.Id,
                    CompanyName=vm.CompanyName
                };
                await _companyService.UpdateAsync(dto);
                _notyfService.Success("Company updated successfuly");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _notyfService.Error(ex.Message);
                return View(vm);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var company = await _companyRepository.GetByAsync(x => x.Id == id);
                var vm = new CompanyDetailsVM()
                {
                    Id = company.Id,
                    CompanyName = company.CompanyName,
                };
                return View(vm);
            }
            catch(Exception ex)
            {
                _notyfService.Error(ex.Message);
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
