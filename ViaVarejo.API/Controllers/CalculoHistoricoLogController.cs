using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ViaVarejo.Application.Interface;
using ViaVarejo.Domain.Entities;
using ViaVarejo.API.ViewModels;
using System.Linq;
using System;

namespace ViaVarejo.API.Controllers
{
    public class CalculoHistoricoLogController : Controller
    {
        private readonly ICalculoHistoricoLogAppService _calculoHistoricoLogAppService;

        public CalculoHistoricoLogController(ICalculoHistoricoLogAppService calculoHistoricoLogApp)
        {
            _calculoHistoricoLogAppService = calculoHistoricoLogApp;
        }

        // GET CalculoHistoricoLog/AddCalculo
        [HttpGet]
        [Route("AddCalculo")]
        public JsonResult AddCalculo(int idAmigoA, int idAmigoB, decimal distanciaAB)
        {
            CalculoHistoricoLog calculoHistoricoLog = new CalculoHistoricoLog()
            {
                IDAmigoA = idAmigoA,
                IDAmigoB = idAmigoB,
                DistanciaAB = distanciaAB
            };

            _calculoHistoricoLogAppService.Add(calculoHistoricoLog);

            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}