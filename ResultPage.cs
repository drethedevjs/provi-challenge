using System.Collections.Generic;

public class ResultPage
{
    public string page {get;set;}
    public int per_page {get; set;}
    public int total {get;set;}
    public int total_pages {get;set;}
    public List<User> data {get;set;}
}