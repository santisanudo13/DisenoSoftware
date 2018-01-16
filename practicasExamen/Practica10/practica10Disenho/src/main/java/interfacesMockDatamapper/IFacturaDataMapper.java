package interfacesMockDatamapper;


import domain.*;
import p8.excepciones.*;


/**
 * Interfaz para los mocks utilizados en la implementacion de los metodos de negocio
 *
 */
public interface IFacturaDataMapper {
	
	public Factura insertFactura(Factura f) throws NoSeHaPodidoConectarABBDD;

	public void updateFactura(Factura f) throws NoSeHaPodidoConectarABBDD;

	public void deleteFactura(Factura f) throws NoSeHaPodidoConectarABBDD;

	public Factura readFactura(long id) throws NoSeHaPodidoConectarABBDD;
	
	public Factura obtenerFacturaActualUsuario(long idUsuario) throws NoSeHaPodidoConectarABBDD;

}
