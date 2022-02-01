using System;
using System.Collections.Generic;
using System.Text;

namespace FaeRealm.Character
{
    internal class LimbNode
    {
        /// <summary>
        /// which body parts extend from this body part
        /// </summary>
        private List<LimbNode> extensions { get; }
        /// <summary>
        /// what kind of gear *can be present* on this limb, not neccesarily what *is* on it.
        /// </summary>
        private List<CharacterBody.EquipmentType> gear { get; }

        public LimbNode(List<LimbNode> extensions, List<CharacterBody.EquipmentType> gear)
            {
                this.extensions = extensions;
                this.gear = gear;
            }
    }
}
