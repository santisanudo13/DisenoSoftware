package interfacesMockDatamapper;

import domain.Visualizacion;
import p8.excepciones.NoSeHaPodidoConectarABBDD;

/**
 * Interfaz para los mocks utilizados en la implementacion de los metodos de negocio
 *
 */
public interface IVisualizacionDataMapper {
	
	public Visualizacion insertUsuario(Visualizacion v) throws NoSeHaPodidoConectarABBDD;

	public void updateVisualizacion(Visualizacion v) throws NoSeHaPodidoConectarABBDD;

	public void deleteVisualizacion(Visualizacion v) throws NoSeHaPodidoConectarABBDD;

	public Visualizacion readVisualizacion(long id) throws NoSeHaPodidoConectarABBDD;
	
}
