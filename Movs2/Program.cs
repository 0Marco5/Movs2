using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

using Newtonsoft.Json;

namespace the_Cryptocurrencies_bot_Movs
{
    public class API
    {
        static async Task Main(string[] args)
        {
            Mensaje m = new Mensaje();
            await m.CheckCAKEAsync();
            await m.CheckCARRAsync();
            await m.CheckCASAsync();
            await m.CheckCHZAsync();
            await m.CheckCROAsync();
            await m.CheckCUDOSAsync();
            await m.CheckDAGAsync();
            await m.CheckDASHAsync();
            await m.CheckDEGOAsync();
            await m.CheckDGBAsync();
            await m.CheckDIAAsync();
            await m.CheckDOGEAsync();
            await m.CheckDOTAsync();
            await m.CheckEOSAsync();
        }
    }
}
