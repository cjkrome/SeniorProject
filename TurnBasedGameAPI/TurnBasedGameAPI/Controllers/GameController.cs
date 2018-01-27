﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TurnBasedGameAPI.Controllers
{
    public class GameController : ApiController
    {

        // GET: api/Game/GameCreate
        /// <summary>
        /// Creates an instance of game. Uses List<Player>
        /// </summary>
        /// coded by Stephen 1/24/18
        /// <param name="players"></param>
        /// <returns>IHttp result code</returns>
        public IHttpActionResult GameCreate(List<Player> players)
        {
            // used to instanciate a game instance
            // args: List of Player, 
            
            try
            {
                using (var db = new Game.ENTITIES()) 
                {
                    // Game thisGame = new Game.Start(players) ;
                }

                return Ok("Game Controller gameCreate API Call");
            }
            catch (Exception e) { return Exception("gameCreate failed to perform as expected. :(   my bad"); }
        }

        // GET: api/Game/GetMyGames
        // Written by Garrick 1/23/18
        /// <summary>
        /// Returns all active User games
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetMyGames() //(GameStatus)
        {
            try
            {
                //var myGames = db.games.where(GameStatus == active)
            }
            catch (Exception e)
            {
                throw new Exception("Error in GetMyGames API call");
            }
            return Ok("Game Controller GetMyGames API Call");
        }

        // GET: api/Game
        /// <summary>
        /// Returns all game records for a passed in
        /// GameID
        /// @Michael Case, 1/23/18
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetGameHistory(GameID id)
        {
            try
            {
                // Need more details of database implementation, but
                // hopefully this is similar to the actual implementation
                using (var db = new Game.ENTITIES())
                {
                    var gameHistory = db.games.where(gameHistory => GetMyGames.id);
                    return Ok("Game Controller GetGameHistory API Call");
                }

            }
            catch (Exception e)
            {
                return Exception("GetGameHistory call failed");
            }
        }
    }
}