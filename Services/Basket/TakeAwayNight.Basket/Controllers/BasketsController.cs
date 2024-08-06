using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Basket.Dtos;
using TakeAwayNight.Basket.LoginServices;
using TakeAwayNight.Basket.Services;

namespace TakeAwayNight.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ILoginServices _loginService;

        public BasketsController(IBasketService basketService, ILoginServices loginServices)
        {
            _basketService = basketService;
            _loginService = loginServices;
        }

        //redisin bu metodu çağrıldığı zaman bize giriş yapan kullanıcının sepetindeki verileri getirecek.
        [HttpGet]
        public async Task<IActionResult> GetMyBasketDetail()
        {
            var values = await _basketService.GetBasket(_loginService.GetUserId);
            return Ok(values);
        }
        // sepete ekleme yada çıkarma işlemi yapıldığını tutacak
        [HttpPost]
        public async Task<IActionResult> SaveMyBasket(BasketTotalDto basket)
        {
            basket.UserId = _loginService.GetUserId;
            await _basketService.SaveBasket(basket);
            return Ok("Sepetteki değişiklikler kaydedildi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            await _basketService.DeleteBasket(_loginService.GetUserId);
            return Ok("Silme işlemi başarılı");
        }
    }
}
