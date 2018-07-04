using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ViaVarejo.Application.Interface;
using ViaVarejo.Domain.Entities;
using ViaVarejo.API.ViewModels;
using System.Linq;
using System;
using System.Net.Http;

namespace ViaVarejo.API.Controllers
{
    public class AmigoController : Controller
    {
        private readonly IAmigoAppService _amigoApp;
        private readonly ICalculoHistoricoLogAppService _calculoHistoricoLogAppService;

        public AmigoController(IAmigoAppService amigoApp, ICalculoHistoricoLogAppService calculoHistoricoLogAppService)
        {
            _amigoApp = amigoApp;
            _calculoHistoricoLogAppService = calculoHistoricoLogAppService;
        }

        // GET Amigo/GetAllAmigo
        [HttpGet]
        [Route("GetAllAmigo")]
        public ActionResult GetAllAmigo()
        {
            var amigoViewModel = Mapper.Map<IEnumerable<Amigo>, IEnumerable<AmigoViewModel>>(_amigoApp.GetAll());

            return Json(new { status = true, message = amigoViewModel.ToList() }, JsonRequestBehavior.AllowGet);
        }

        // GET Amigo/AddAmigo
        [HttpGet]
        [Route("AddAmigo")]
        public ActionResult AddAmigo(string nome, string endereco, decimal posX, decimal posY)
        {
            try
            {
                if (_amigoApp.BuscarPorPosicao(posX, posY) == null)
                {
                    Amigo amigo = new Amigo()
                    {
                        Nome = nome,
                        Endereco = endereco,
                        PosX = posX,
                        PosY = posY
                    };

                    _amigoApp.Add(amigo);

                }
                else
                {
                    return Json(new { status = false, message = "Posição já cadastrada no Mapa" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { status = true, message = "" }, JsonRequestBehavior.AllowGet);
        }

        // GET Amigo/CalcularDistancia?idAmigoA
        [HttpGet]
        [Route("CalcularDistancia")]
        public ActionResult CalcularDistancia(int idAmigoA)
        {
            var amigoViewModel = Mapper.Map<IEnumerable<Amigo>, IEnumerable<AmigoViewModel>>(_amigoApp.GetAll());

            try
            {
                decimal posXA = amigoViewModel.Where(x => x.ID == idAmigoA).FirstOrDefault().PosX;
                decimal posYA = amigoViewModel.Where(x => x.ID == idAmigoA).FirstOrDefault().PosY;
                decimal posXB, posYB, distancia;
                int idAmigoB;

                //Realiza o cálculo da distância para cada amigo
                foreach (AmigoViewModel amigo in amigoViewModel)
                {
                    if (amigo.ID != idAmigoA)
                    {
                        idAmigoB = amigo.ID;
                        posXB = amigo.PosX;
                        posYB = amigo.PosY;

                        //Fórmula
                        //      ________________________
                        // D = V (xA - xB)² + (yA - yB)²

                        double calcA = Math.Pow(Convert.ToDouble(posXA - posXB), 2);
                        double calcB = Math.Pow(Convert.ToDouble(posYA - posYB), 2);

                        distancia = Convert.ToDecimal(Math.Sqrt(calcA + calcB));

                        amigo.Distancia = distancia;

                        //Insere os cálculos no log
                        var calculoHistoricoLogController = new CalculoHistoricoLogController(_calculoHistoricoLogAppService);

                        calculoHistoricoLogController.AddCalculo(idAmigoA, idAmigoB, distancia);
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { status = true, message = amigoViewModel.OrderBy(x => x.Distancia).ToList() }, JsonRequestBehavior.AllowGet);
        }
    }
}