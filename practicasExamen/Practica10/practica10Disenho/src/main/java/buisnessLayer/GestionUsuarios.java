package buisnessLayer;

import static org.mockito.Mockito.mock;

import java.util.Date;
import java.util.List;

import buisnessLayerInterfaces.IGestionUsuarios;
import datamappers.SerieDataMapper;
import domain.Factura;
import domain.Serie;
import domain.Usuario;
import domain.Visualizacion;
import dto.AgregarSerieDTO;
import dto.CapituloDTO;
import dto.FacturaDTO;
import dto.PaginaPrincipalDTO;
import interfacesMockDatamapper.IFacturaDataMapper;
import interfacesMockDatamapper.IUsuarioDataMapper;
import p8.excepciones.NoSeHaPodidoConectarABBDD;

/**
 * Gestion Usuarios
 *
 */
public class GestionUsuarios implements IGestionUsuarios {

	/**
	 * Metodo para el login de los usuarios
	 * @param usuario
	 */
	@Override
	public void autenticarse(Usuario usuario) {

	}

	/**
	 * Metodo para el registro de usuarios
	 * @param usuario
	 */
	@Override
	public void registrarse(Usuario usuario) {

	}

	/**
	 * Metodo para obtener los cargos del usuario
	 * @return cargos del usuario
	 */
	@Override
	public List<FacturaDTO> verCargos() {
		return null;
	}

	/**
	 * Metodo para obtener los cargos del usuario pertenecientes a un determinado mes
	 * @return cargos del usuario
	 */
	@Override
	public FacturaDTO verCargos(Date fecha) {
		return null;
	}

	/**
	 * Metodo para obtener la pagina principal del usuario
	 * @return pagina principal del usuario
	 */
	@Override
	public PaginaPrincipalDTO obtenerEspacioPersonal() {
		return null;
	}

	/**
	 * Metodo para anadir una nueva serie al espacio personal del usuario
	 * @param serie
	 * @throws NoSeHaPodidoConectarABBDD 
	 */
	@Override
	public void anadirSerieAEspacioPersonal(AgregarSerieDTO serie, long idUsuario) throws NoSeHaPodidoConectarABBDD, 
	SerieYaPendiente, SerieYaComenzada, SerieYaTerminada {

		SerieDataMapper serieMapper = new SerieDataMapper();
		Serie serie2 = serieMapper.readSerie(serie.getId());

		IUsuarioDataMapper usuarioMapper = mock(IUsuarioDataMapper.class);
		Usuario usuario = usuarioMapper.readUsuario(idUsuario);

		List<Serie> seriesPendientes = usuario.getSeriesPendientes();
		List<Serie> seriesComenzadas = usuario.getSeriesComenzadas();
		List<Serie> seriesTerminadas = usuario.getSeriesTerminadas();

		if(seriesPendientes.contains(serie2)) {
			throw new SerieYaPendiente();
		} else if(seriesComenzadas.contains(serie2)) {
			throw new SerieYaComenzada();
		} else if(seriesTerminadas.contains(serie2)) {
			throw new SerieYaTerminada();
		} else {
			usuario.getSeriesPendientes().add(serie2);
		}

		usuarioMapper.updateUsuario(usuario);

	}

	/**
	 * Metodo para anadir un cargo a la factura mensual de un usuario
	 * @param visualizacion
	 */
	@Override
	public void anadirCargoAFactura(Visualizacion visualizacion) throws NoSeHaPodidoConectarABBDD {

		IFacturaDataMapper facturaMapper = mock(IFacturaDataMapper.class);
		Factura factura = facturaMapper.obtenerFacturaActualUsuario(visualizacion.getUsuario().getId());

		factura.anadirCargo(visualizacion);

		facturaMapper.updateFactura(factura);

	}

	/**
	 * Metodo para cobrar un mes al usuario
	 * @param fecha
	 */
	@Override
	public void facturarMes(Date fecha) {}

	/**
	 * Metodo para visualizar un capitulo
	 * @param capitulo
	 */
	@Override
	public void visualizarCapitulo(CapituloDTO capitulo) {}

}
