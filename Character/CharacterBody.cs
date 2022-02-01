using System;
using System.Collections.Generic;
using System.Text;

namespace FaeRealm.Character
{
    internal class CharacterBody
    {
        public enum EquipmentType {boot, glove, bangle, necklace, pants, shirt, overshirt, hat, belt, Eyewear, ring}
        public CharacterBody()
        {
            //feet
            LimbNode feet = new LimbNode(null, 
                new List<EquipmentType> { EquipmentType.boot });
            //left hand
            LimbNode leftHand = new LimbNode(null, 
                new List<EquipmentType> { EquipmentType.ring});
            //right hand
            LimbNode rightHand = new LimbNode(null,
                new List<EquipmentType> { EquipmentType.ring });
            //legs (wears nothing)
            LimbNode legs = new LimbNode( new List<LimbNode>{ feet },
                null);
            //left arm
            LimbNode leftArm = new LimbNode(new List<LimbNode> { leftHand },
                new List<EquipmentType> { EquipmentType.bangle });
            //right arm
            LimbNode rightArm = new LimbNode(new List<LimbNode> { rightHand },
                new List<EquipmentType> { EquipmentType.bangle });
            //hips (contains pants and belt)
            LimbNode hips = new LimbNode(new List<LimbNode> { legs },
                new List<EquipmentType> { EquipmentType.belt, 
                                          EquipmentType.pants });
            //torso
            LimbNode torso = new LimbNode(new List<LimbNode> { leftArm, rightArm, hips },
                new List<EquipmentType> { EquipmentType.shirt, 
                                          EquipmentType.overshirt });
            //head (suggestably contains neck)
            LimbNode head = new LimbNode(new List<LimbNode> { torso },
                new List<EquipmentType> { EquipmentType.hat, 
                                          EquipmentType.Eyewear, 
                                          EquipmentType.necklace });
        }
    }
}
