namespace API_RestFull.Models
{
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.Detail_Commande = new HashSet<Detail_Commande>();
        }

        public int ID_Commande { get; set; }
        public System.DateTime DATE_Commande { get; set; }
        public int ID_Client { get; set; }
        public string Total_HT { get; set; }
        public string TVA { get; set; }
        public string Total_TTC { get; set; }

        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail_Commande> Detail_Commande { get; set; }
    }
}