package proxy;

import java.util.List;

import domain.Artista;
import domain.Creador;
import domain.Serie;
import domain.Temporada;
import p8.excepciones.NoSeHaPodidoConectarABBDD;

/**
 * Proxy de la SerieSilver
 *
 */
public class SerieSilverProxy extends Serie {

	private SerieSilverReal serieReal;

	/**
	 * Constructor
	 * @param nombre
	 * @param sinopsis
	 */
	public SerieSilverProxy(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}

	/* Metodos para gestionar el lazy load a traves del objeto de la "Serie Real" */

	@Override
	public Creador getCreador() throws NoSeHaPodidoConectarABBDD {

		if(serieReal == null){
			this.serieReal = new SerieSilverReal(getNombre(),getSinopsis());
		}

		return serieReal.getCreador();
	}

	public List<Artista> getArtistas() throws NoSeHaPodidoConectarABBDD{

		if(serieReal == null){
			this.serieReal = new SerieSilverReal(getNombre(),getSinopsis());
		} 

		return serieReal.getArtistas();
	}

	public List<Temporada> getTemporadas() throws NoSeHaPodidoConectarABBDD{

		if(serieReal == null){
			this.serieReal = new SerieSilverReal(getNombre(),getSinopsis());
		}

		return serieReal.getTemporadas();
	}

	@Override
	public void setCreador(Creador creador) {
		serieReal.setCreador(creador);
	}

	@Override
	public void setArtistas(List<Artista> artistas) {
		serieReal.setArtistas(artistas);
	}

	@Override
	public void setTemporadas(List<Temporada> temporadas) {
		serieReal.setTemporadas(temporadas);
	}

}
