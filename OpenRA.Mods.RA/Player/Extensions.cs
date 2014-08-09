#region Copyright & License Information
/*
 * Copyright 2007-2014 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using System.Linq;
using OpenRA.Mods.RA;

namespace OpenRA
{
	public static class Extensions
	{
		public static bool HasNoRequiredUnits(this Player player)
		{
			return player.World.ActorsWithTrait<MustBeDestroyed>().All(p => p.Actor.Owner != player);
		}
	}
}