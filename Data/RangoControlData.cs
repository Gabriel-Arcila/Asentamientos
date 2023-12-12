using Asentamientos.ModelsViews;
using Asentamientos.Models;
using Asentamientos.DTOs;
using Asentamientos.Interface;

namespace Asentamientos.Data
{
    public class ProductosVData : IProductosVData
    {
        private HttpClient cliente { get; set; }
        private HttpResponseMessage mensaje { get; set; }

        private string url {get; set;}
        public async Task<List<ProductosV>> GetProductosPorLinea(int idLinea){
            List<ProductosV> productos;
            url = $"http://neo.paveca.com.ve/apineomaster/api/RangoControl/GetProductosPorLinea/{idLinea}";
            cliente = new HttpClient();
            productos = await cliente.GetFromJsonAsync<List<ProductosV>>(url) ?? new List<ProductosV>();
            return productos;
        }
    }
    public class SeccionesVData : ISeccionesVData
    {
        private HttpClient cliente { get; set; }
        private HttpResponseMessage mensaje { get; set; }
        private string url {get; set;}
        public async Task<List<SeccionesV>> GetSeccionesPorLinea(int idLinea){
            List<SeccionesV> secciones;
            url = $"http://neo.paveca.com.ve/apineomaster/api/RangoControl/GetSeccionesPorLinea/{idLinea}";
            cliente = new HttpClient();
            secciones = await cliente.GetFromJsonAsync<List<SeccionesV>>(url) ?? new List<SeccionesV>();
            return secciones;
        }
    
    }

    public class RangoData : IRangoData{
        private HttpClient cliente { get; set; }
        private HttpResponseMessage mensaje { get; set; }
        private string url {get; set;}

        public async Task<List<Rango>> GetRangoDeControl(FiltrosRangoControlDTO filtros){
            List<Rango> rangos;
            url = $"http://neo.paveca.com.ve/apineomaster/api/RangoControl/GetRangoDeControl?producto={filtros.producto}&master={filtros.master}&tipo={filtros.tipo}&seccion={filtros.seccion}";
            cliente = new HttpClient();
            rangos = await cliente.GetFromJsonAsync<List<Rango>>(url) ?? new List<Rango>();
            return rangos;
        }
    }
}