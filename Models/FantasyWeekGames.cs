using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeBase.Models
{
    public class FantasyWeekGames
    {
        public int ID { get; set; }
        [StringLength(500, MinimumLength = 3)]
        [Required]
public int WeekNumber { get; set; }        
public int ATL_Games { get; set; }   
public int BOS_Games{ get; set; }  
public int BKN_Games	{ get; set; }  
public int CHA_Games	{ get; set; }  
public int CHI_Games	{ get; set; }  
public int CLE_Games	{ get; set; }  
public int DAL_Games	{ get; set; }  
public int DEN_Games	{ get; set; }  
public int Det_Games	{ get; set; }  
public int GSW_Games	{ get; set; }  
public int HOU_Games	{ get; set; }  
public int IND_Games	{ get; set; }  
public int LAC_Games	{ get; set; }  
public int LAL_Games	{ get; set; }  
 public int MEM_Games	{ get; set; }  
 public int MIA_Games	{ get; set; }  
 public int MIL_Games	{ get; set; }  
 public int MIN_Games	{ get; set; }  
 public int NOP_Games	{ get; set; }  
 public int NYK_Games	{ get; set; }  
 public int OKC_Games	{ get; set; }  
 public int ORL_Games	{ get; set; }  
 public int PHI_Games	{ get; set; }  
public int PHO_Games	{ get; set; }  
 public int POR_Games { get; set; }  
 public int SAC_Games	{ get; set; }  
 public int SAS_Games	{ get; set; }   
 public int TOR_Games	{ get; set; }  
public int UTA_Games	{ get; set; }  
 public int WAS_Games	{ get; set; }  
      

    }
}