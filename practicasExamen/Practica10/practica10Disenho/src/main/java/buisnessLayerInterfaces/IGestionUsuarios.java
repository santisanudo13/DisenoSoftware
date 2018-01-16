package buisnessLayerInterfaces;

import java.util.Date;
import java.util.List;

import buisnessLayer.*;
import domain.*;
import dto.*;
import p8.excepciones.*;

/**
 * Interfaz para la gestion de las operaciones relativas a los usuarios
 *
 */
public interface IGestionUsuarios {

	/**
	 * Metodo para el login de los usuarios
	 * @param usuario
	 */
	public void autenticarse(Usuario usuario);
	
	/**
	 * Metodo para el registro de usuarios
	 * @param usuario
	 */
	public void registrarse(Usuario usuario);
	
	/**
	 * Metodo para obtener los cargos del usuario
	 * @return cargos del usuario
	 */
	public List<FacturaDTO> verCargos();
	
	/**
	 * Metodo para obtener los cargos del usuario pertenecientes a un determinado mes
	 * @return cargos del usuario
	 */
	public FacturaDTO verCargos(Date fecha);
	
	/**
	 * Metodo para obtener la pagina principal del usuario
	 * @return pagina principal del usuario
	 */
	public PaginaPrincipalDTO obtenerEspacioPersonal();
	
	/**
	 * Metodo para anadir una nueva serie al espacio personal del usuario
	 * @param serie
	 * @throws NoSeHaPodidoConectarABBDD 
	 */
	public void anadirSerieAEspacioPersonal(AgregarSerieDTO serie, long idUsuario) throws NoSeHaPodidoConectarABBDD, 
													SerieYaPendiente, SerieYaComenzada, SerieYaTerminada;
	
	/**
	 * Metodo para anadir un cargo a la factura mensual de un usuario
	 * @param visualizacion
	 */
	public void anadirCargoAFactura(Visualizacion visualizacion) throws NoSeHaPodidoConectarABBDD;
	
	/**
	 * Metodo para cobrar un mes al usuario
	 * @param fecha
	 */
	public void facturarMes(Date fecha);
	
	/**
	 * Metodo para visualizar un capitulo
	 * @param capitulo
	 */
	public void visualizarCapitulo(CapituloDTO capitulo);
	
}
