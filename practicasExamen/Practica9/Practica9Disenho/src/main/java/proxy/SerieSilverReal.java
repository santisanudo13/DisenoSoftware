package proxy;

import java.util.List;

import datamappers.SerieDataMapper;
import domain.Artista;
import domain.Creador;
import domain.Serie;
import domain.Temporada;
import p8.excepciones.NoSeHaPodidoConectarABBDD;

/**
 * Objeto SerieSilver "Real" para obtener de la bbdd los datos mediante la estrategia lazy load
 *
 */
public class SerieSilverReal extends Serie {

	/**
	 * Constructor
	 * @param nombre
	 * @param sinopsis
	 */
	public SerieSilverReal(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}

	/* Metodos para obtener los datos, a traves de los data mappers, de la BBDD */

	@Override
	public Creador getCreador() throws NoSeHaPodidoConectarABBDD {
		this.creador = new SerieDataMapper().findSerieCreator(this);
		return creador;
	}

	@Override
	public List<Artista> getArtistas() throws NoSeHaPodidoConectarABBDD {
		this.artistas = new SerieDataMapper().findSerieArtists(this);
		return artistas;
	}

	@Override
	public List<Temporada> getTemporadas() throws NoSeHaPodidoConectarABBDD {
		this.temporadas = new SerieDataMapper().findSerieSeasons(this);
		return temporadas;
	}

}
