﻿using LudumDare.Core;
using LudumDare.Model;
using UnityEngine;

namespace LudumDare.Controller
{
    public class LapController : AbstractController
    {
        private GameModel gameModel = null;

        protected override void Start()
        {
            base.Start();

            gameModel = Models.GetModel<GameModel>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                gameModel.lap++;
            }
        }
    }
}