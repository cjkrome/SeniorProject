//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class GameState
    {
        public int ID { get; set; }
        public string GameState1 { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int GameID { get; set; }
    
        public virtual Game Game { get; set; }
    }
}
