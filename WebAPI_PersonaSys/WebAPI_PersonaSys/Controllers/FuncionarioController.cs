﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_PersonaSys.Models;
using WebAPI_PersonaSys.Service.FuncionarioService;

namespace WebAPI_PersonaSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController: ControllerBase
    {
        private readonly IFuncionarioInterface _funcionarioInterface;

        public FuncionarioController(IFuncionarioInterface funcionarioInterface)
        {
            _funcionarioInterface= funcionarioInterface;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>>GetFuncionarios()
        {

            return Ok(await _funcionarioInterface.GetFuncionarios());
        }



    }
}
