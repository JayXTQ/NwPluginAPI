using LiteNetLib;
using UnityEngine;

using AdminToys;
using PlayerRoles;
using Footprinting;
using CustomPlayerEffects;
using MapGeneration.Distributors;

using Interactables.Interobjects;
using Interactables.Interobjects.DoorUtils;

using CommandSystem;
using PlayerStatsSystem;

using InventorySystem.Items;
using InventorySystem.Items.Radio;
using InventorySystem.Items.Pickups;
using InventorySystem.Items.Usables;
using InventorySystem.Items.Firearms;
using InventorySystem.Items.ThrowableProjectiles;

using PluginAPI.Core;
using PluginAPI.Enums;
using PluginAPI.Core.Attributes;

using static BanHandler;
using static MapGeneration.Distributors.Scp079Generator;

namespace PluginAPI.Events
{
	public class PlayerRemoveHandcuffsEvent : IEventArguments
	{
		public ServerEventType BaseType { get; } = ServerEventType.PlayerRemoveHandcuffs;
		[EventArgument]
		public Player Player { get; }
		[EventArgument]
		public Player Target { get; }
		[EventArgument]
		public bool CanRemoveHandcuffsAsScp { get; set; } = false;

		public PlayerRemoveHandcuffsEvent(ReferenceHub hub, ReferenceHub target)
		{
			Player = Player.Get(hub);
			Target = Player.Get(target);
		}

		PlayerRemoveHandcuffsEvent() { }
	}
}