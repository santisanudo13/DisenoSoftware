package proxy;

import java.util.List;

import datamappers.SerieDataMapper;
import domain.Artista;
import domain.Creador;
import domain.Serie;
import domain.Temporada;
import p8.excepciones.NoSeHaPodidoConectarABBDD;


/**
 * Proxy de la SerieEstandar
 *
 */
public class SerieProxy extends Serie {


	private boolean creadorLoaded = false;
	/**
	 * Constructor
	 * @param nombre
	 * @param sinopsis
	 */
	public SerieProxy(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}


	@Override
	public Creador getCreador()  {
		try {
			if(!creadorLoaded){
				this.creador = new SerieDataMapper().findSerieCreator(this);
				creadorLoaded = true;
			} 
		}catch(NoSeHaPodidoConectarABBDD e) {

		}
		return creador;
	}

	@Override
	public List<Artista> getArtistas() {
		try{
			if(artistas == null){
				this.artistas = new SerieDataMapper().findSerieArtists(this);
			}
		}catch(NoSeHaPodidoConectarABBDD e) {

		}
		return artistas;
	}

	public List<Temporada> getTemporadas() {
		try{
			if(temporadas == null){
				this.temporadas = new SerieDataMapper().findSerieSeasons(this);
			} 
		}catch(NoSeHaPodidoConectarABBDD e) {

		}
		return temporadas;
	}

	@Override
	public void setCreador(Creador creador) {
		this.creador = creador;
		if(!creadorLoaded)
			creadorLoaded = true;
	}

	@Override
	public void setArtistas(List<Artista> artistas) {
		this.artistas = artistas;
	}

	@Override
	public void setTemporadas(List<Temporada> temporadas) {
		this.temporadas = temporadas;
	}

	public boolean isCreadorLoaded() {
		return creadorLoaded;
	}

	public void setCreadorLoaded(boolean creadorLoaded) {
		this.creadorLoaded = creadorLoaded;
	}

}
