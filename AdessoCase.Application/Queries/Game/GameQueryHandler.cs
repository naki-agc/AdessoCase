using AdessoCase.Domain.Entites;
using MediatR;

namespace AdessoCase.Application.Queries.Game
{
    public class GameQueryHandler : IRequestHandler<GameQueryModel, GameResponseModel>
    {

        public async Task<GameResponseModel> Handle(GameQueryModel request, CancellationToken cancellationToken)
        {

            var players = new List<Player>();
            for(int i = 0; i< request.PeopleCount; i++)
            {
                players.Add(new Player // oyuncu listesi oluşturuluyor
                {
                    PlayerNumber = (i + 1),
                    PlyerName = $"{(i + 1)} .Oyuncu"
                });
            }

            var deletedGamer = 1;
            var roundCount = 1;
            while(players.Count > 1) // tek oyuncu kalana kadar devam et
            {
                if(deletedGamer  >= players.Count)
                {
                    deletedGamer = 0; // başa döndüğünde son oyuncudan sonra silinekce olan oyuncu ilk oyuncu olmalı
                    roundCount++;
                }
                var willBeDeletedGamer = players[deletedGamer];
                players.Remove(willBeDeletedGamer);
                deletedGamer++;
            }
            /*
              // 5 kişilik örnek senaryo
              1 3 4 5
              1 3 5
              3 5
              3
             */
            var response = new GameResponseModel
            {
                WinnerGamer = players.FirstOrDefault().PlyerName,
                RoundCount = roundCount
            };
        
            return response;
        }
    }
}
