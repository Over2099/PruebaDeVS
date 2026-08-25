using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerPruebaController : Controller
    {
        public IActionResult Index()
        {
            string msn = "Hola Mundo";
            return Ok(new
            {
                msn });
        }

        [HttpGet("iva")]
        public IActionResult CalcIVA(
            [FromQuery] decimal precio
            )
        {
            decimal iva = precio * (decimal) 0.15;
            return Ok(
                new
                {
                    precio,
                    iva
                });
        }
        [HttpGet("estudiante")]
        public IActionResult NotaStudent(
            [FromQuery] decimal nota)
        {
            string calificacion;

            if (nota >= 90 && nota <= 100)
            {
                calificacion = "Logro destacado (90-100 pts): Dominio sobresaliente: evidencia autonomía, calidad técnica.";
            }
            else if (nota >= 80 && nota <= 89)
            {
                calificacion = "Logrado suficientemente (80-89 pts): Dominio suficiente: aplica de manera integrada las habilidades y conocimientos.";
            }
            else if (nota >= 70 && nota <= 79)
            {
                calificacion = "Logro en proceso intermedio (70-79 pts): Dominio parcial: aplica conocimientos esenciales, aunque requiere consolidar su integración y transferencia.";
            }
            else if (nota >= 60 && nota <= 69)
            {
                calificacion = "Logro en proceso inicial (60-69 pts): Dominio limitado: se evidencian habilidades parciales y dificultad para aplicarlas de forma autónoma.";
            }
            else if (nota >= 0 && nota <= 59)
            {
                calificacion = "Logro deficiente (0-59 pts): Dominio nulo: no se evidencian las habilidades, destrezas y capacidades esperadas.";
            }
            else
            {
                calificacion = "Puntaje fuera de rango. Debe estar entre 0 y 100.";
            }

            return Ok(
                new
                {
                    nota,
                    calificacion
                });
        }
    }

}
