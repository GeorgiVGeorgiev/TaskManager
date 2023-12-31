﻿namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.Client;

    using static Common.NotificationMessages;
    using static Common.ErrorMessageBulgarian;

    [Authorize(Roles = "Administrator,Worker")]
    public class ClientController : Controller
    {
        private readonly IClientService clientService;
        private readonly IUserService userService;
        public ClientController(IClientService clientService, IUserService userService)
        {
            this.clientService = clientService;
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Clients([FromQuery]AllClientQueryModel queryModel)
        {
            try
            {
                bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());
                if (!isUserWorker)
                {
                    return ErrorIfUserIsNotWorker();
                }
                AllClientsFilteredANdPageServiceModel serviceModel= await this.clientService.GetAllClientFilteredAsync(queryModel);
                queryModel.TotalTaskss = serviceModel.TotalClients;
                queryModel.Client = serviceModel.Clients;

                return View(queryModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

                [HttpGet]
        public async Task<IActionResult> Edit(string Id)
        {
            try
            {
                if (!await CheckIfUserIsWorkerAndClientExist(Id))
                {
                    return GeneralError();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }

            ClientFormModel formModel = await this.clientService.GetClientFormByIdAsync(Id);
            return View(formModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ClientViewModel viewModel, string Id)
        {
            try
            {
                if (!await CheckIfUserIsWorkerAndClientExist(Id))
                {
                    return GeneralError();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                await this.clientService.EditClientAsnyc(viewModel,Id);

                return this.RedirectToAction("Clients", "Client");
            }
            catch (Exception)
            {
                return GeneralError();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
            {
                bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());
                if (!isUserWorker)
                {
                    return ErrorIfUserIsNotWorker();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                ClientFormModel formModel = new ClientFormModel();

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Add(ClientFormModel formModel)
        {
            try
            {
                bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());
                if (!isUserWorker)
                {
                    return ErrorIfUserIsNotWorker();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                await this.clientService.AddClientAsync(formModel);

                return this.RedirectToAction("Clients", "Client");
            }
            catch (Exception)
            {
                return GeneralError();
            }

        }

        private IActionResult ErrorIfUserIsNotWorker()
        {
            this.TempData[ErrorMessage] = ErrorIfUserIsNotWorkerMessage;

            return RedirectToAction("Index", "Home");
        }
        private IActionResult ErrorIfClientDosNotExist()
        {
            this.TempData[ErrorMessage] = ErrorIfClientDontExistMessage;

            return RedirectToAction("Index", "Home");
        }
        private async Task<bool> CheckIfUserIsWorkerAndClientExist(string clientId)
        {
            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());
            bool isClientExist = await this.clientService.IsClientExitByIdAsync(clientId);
            if(isUserWorker && isClientExist)
            {
                return true;
            }
            return false;
        }
        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = GeneralErrorMessage;

            return RedirectToAction("Index", "Home");
        }

    }
}
