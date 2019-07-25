using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace ProyectoGiasaWeb.Models
{
    public class GiasaModeloDB
    {
        // Inputs y Errores de base de datos
    }
    [Table("Vendedor")]// Sustituida por TUsuario
    public class Vendedor
    {
        [Key]
        [Required]
        public Int32 idVendedor { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String usuario { get; set; }
        public String pass { get; set; }
        public String fechaAlta { get; set; }
        public DateTime ultimaEntrada { get; set; }


    }
    [Table("Prospectos")]// Vistas, Controlador Terminado
    public class Prospectos
    {
        [Key]
        [Required]
        public Int32 idProspecto { get; set; }
        [DisplayName("Nombre(s)")]
        public String nombrepros { get; set; }
        [DisplayName("Apellido Pa.")]
        public String ap_paterno { get; set; }
        [DisplayName("Apellido Ma.")]
        public String ap_materno { get; set; }
        
        public String direccion { get; set; }
       
        public String correo { get; set; }
        public String empresa { get; set; }
    }
    [Table("Insumo")]
    public class Insumo// Vistas Controlador Terminado
    {
        [Key]
        [Required]
        public Int32 idInsumo { get; set; }
        public Int32 noPlaca { get; set; }
        public Decimal subTotal { get; set; }
        [ForeignKey("tbaMaquinaria")]
        public Int32 Maquinaria_idMaquina { get; set; }
        [ForeignKey("Cat_tinta")]
        public Int32 Cat_tinta_idTinta { get; set; }


        //FK Maquinaria, tinta
        
        //  public List<Color>Color { get; set; }

    }
    [Table("CatPlaca")]
    public class CatPlaca// Vistas Controlador Terminado
    {
        [Key]
        [Required]
        public Int32 idPlaca { get; set; }
        [Required(ErrorMessage = "<font color='red'>Campo Nombre Placa Obligatorio</font>")]
        [DisplayName("Descripcion Placa")]
        public String desPlaca { get; set; }
        public String medida { get; set; }
        [Required(ErrorMessage = "<font color='red'>Campo Costo Placa Obligatorio</font>")]
        public Decimal costoPlaca { get; set; }



    }
    [Table("CatInsumo")]
    public class CatInsumo// Vistas Controlador Terminado
    {
        [Key]
        [Required]
        public Int32 idCatinsumo { get; set; }
        public String insumo { get; set; }
        [DisplayName("Horas De Insumo")]
        public Decimal costohr { get; set; }
    }
    
    [Table("Producto")]
    public class Producto// Vista Controlador Terminado
    {
        [Key]
        [Required]
        public Int32 idProducto { get; set; }
        [DisplayName("Descripcion del Producto")]
        public String desProducto { get; set; }
       



    }

    [Table("Cat_tinta")]
    public class Cat_tinta
    {
        [Key]
        [Required]
        public Int32 idTinta { get; set; }
        [DisplayName("Tinta Nombre")]
        public String nombretin { get; set; }
        public Decimal precio { get; set; }

    }// Vistas Controlador Terminado
    [Table("CatColor")]
    public class Color
    {
        [Key]
        [Required]

        public Int32 idColores { get; set; }
        //[ForeignKey("Cat_tinta")]
        public Int32 Cat_tinta_idTinta { get; set; }
        //[ForeignKey("tbaInsumo")]
        public Int32 Insumo_idInsumo { get; set; }

        // FK de Cat_tinta, Insumos

        // public List<Cat_tinta> Cat_tintas { get; set; }
        // public List<tbaInsumo> tbaInsumos { get; set; }


    }
    [Table("Material")]
    public class Material
    {
        [Key]
        [Required]
        public Int32 idMaterial { get; set; }
        public Decimal subtotal { get; set; }

    }
    [Table("Papel")]
    public class Papel
    {
        [Key]
        [Required]
        public Int32 idPapel { get; set; }
        [DisplayName("Papel Nombre")]
        public String nombre { get; set; }
        public Decimal precio { get; set; }

    }// vistas Generadas
    [Table("PapelMat")]
    public class PapelMat
    {
        [Key]
        [Required]
        public Int32 idPapelMat { get; set; }
        public Int32 cantidad { get; set; }
        public Decimal importe { get; set; }//revisar
        //[ForeignKey("papel")]
        public Int32 papel_idPapel { get; set; }
        //[ForeignKey("tbaMaterial")]
        public Int32 tbaMaterial_idMaterial { get; set; }

        //FK de papel, tbaMaterial
       
    }// Generadas en otro proyecto como page
    [Table("Indirecto")]
    public class Indirecto
    {
        [Key]
        [Required]
        public Int32 idIndirecto { get; set; }
        [DisplayName("Horas Indirecto")]
        public Decimal horas { get; set; }
        [DisplayName("Minutos De Insumo")]
        public Int32 minutos { get; set; }//revisar
        public Decimal importe { get; set; }
        public Decimal subtotalP { get; set; }
        [DisplayName("Valor Insumo")]
        public Decimal insumoV { get; set; }
        [DisplayName("Valor Material")]
        public Decimal materialV { get; set; }//revisar
        [DisplayName("Valor Sub Total")]
        public Decimal subtotalV { get; set; }


    }
    [Table("MaquilasCot")]
    public class MaquilasCot
    {
        [Key]
        [Required]
        public Int32 idMaquilaTba { get; set; }
        //[ForeignKey("maquilatba")]
        public Int32 maquilas_idMaquila { get; set; }
        //[ForeignKey("tbaMaquila")]
        public Int32 tbaMaquila_idMaquila { get; set; }//revisar

        //fk maquilas tbaMaquilas

        

    }
    [Table("CotMaquilas")]
    public class CotMaquilas
    {
        [Key]
        [Required]
        public int idMaquila { get; set; }
        public Decimal subtotal { get; set; }

    }
    [Table("Maquilas")]
    public class Maquilas
    {
        [Key]
        [Required]
        public int idMaquila { get; set; }
        public String nombreMaq { get; set; }
        public Decimal precio { get; set; }

    }// Vistas Terminada, Controlador
    [Table("Cotizacion")]
    public class Cotizacion
    {
        [Key]
        [Required]
        public Int32 idCotizacion { get; set; }
        public String folio { get; set; }
        public DateTime fecha { get; set; }//revisar
        public Decimal total { get; set; }
        [DisplayName("Margen")]
        public Decimal margenp { get; set; }
        public Decimal iva { get; set; }
        public Decimal grantotal { get; set; }//revisar
        public Decimal viatico { get; set; }
        //Fk
        //[ForeignKey("tbaVendedor")]
        public Int32 tbaVendedor_idVendedor { get; set; }
        //[ForeignKey("tbaProspectos")]
        public Int32 tbaProspectos_idProspecto { get; set; }
        //[ForeignKey("tbaIndirecto")]
        public Int32 tbaIndirecto_idIndirecto { get; set; }//revisar
        //[ForeignKey("tbaMaquila")]
        public Int32 tbaMaquila_idMaquila { get; set; }
        //[ForeignKey("mano_obra")]
        public Int32 mano_obra_idmano { get; set; }
        //[ForeignKey("tbaInsumo")]
        public Int32 tbaInsumo_idInsumo { get; set; }
        //[ForeignKey("tbaMaterial")]
        public Int32 tbaMaterial_idMaterial { get; set; }

        public Decimal cantidadP { get; set; }

        //fK de vendor, tba todos.
        

    }
    [Table("Mano_obra")]
    public class Mano_obra
    {
        [Key]
        [Required]
        public Int32 idmano { get; set; }
        [DisplayName("Minutos De Diseño")]
        public Int32 minDiseno { get; set; }
        [DisplayName("Costo De Diseño")]
        public Decimal costoDiseño { get; set; }
        [DisplayName("Minutos Prensa")]
        public Int32 minPrensa { get; set; }//revisar
        [DisplayName("costo Prensista")]
        public Decimal costoPren { get; set; }
        [DisplayName("Minutos Foliador")]
        public Int32 minFoliador { get; set; }
        [DisplayName("Minutos Terminado")]
        public Int32 minterminado { get; set; }
        [DisplayName("Costo Foliador")]
        public Decimal costoFolio { get; set; }//revisar
        [DisplayName("Costo Terminado")]
        public Decimal costoTerminado { get; set; }
        public Decimal subtotal { get; set; }





    }// Vistas Terminadas, Controlador
    [Table("Maquinaria")]
    public class Maquinaria
    {
        [Key]
        [Required]
        public int IdMaquina { get; set; }
        [DisplayName("Nombre Maquina")]
        public String nombreMaquina { get; set; }
        [DisplayName("Descripcion")]
        public String desMaquina { get; set; }
        public String funcion { get; set; }
        //fk
        public Int32 CatInsumo_idCatinsumo { get; set; }

        public Int32 Placa_idPlaca { get; set; }
        public Int32 CatIsumos_idCatinsu { get; set; }
        [DisplayName("Precio x Hora")]
        public Decimal preciohr { get; set; }
    }

    }
