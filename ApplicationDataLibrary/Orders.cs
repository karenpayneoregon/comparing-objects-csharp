﻿

namespace ApplicationDataLibrary;

public class Orders
{
    public int OrderID { get; set; }

    public int? CustomerIdentifier { get; set; }
    public string Company { get; set; }
    public DateTime? OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public override string ToString() => $"{OrderID}, {Company}";

}