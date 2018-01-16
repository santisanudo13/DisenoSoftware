package domain;

/**
 * Persona
 *
 */
public abstract class Persona {

	private long id;
	private String nombre;
	private String apellido1;
	private String apellido2;

	/**
	 * Constructor
	 * @param nombre
	 * @param apellido1
	 * @param apellido2
	 */
	public Persona(String nombre, String apellido1, String apellido2) {
		super();
		this.nombre = nombre;
		this.apellido1 = apellido1;
		this.apellido2 = apellido2;
	}
	
	/* Getters y Setters  */
	
	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getApellido1() {
		return apellido1;
	}

	public void setApellido1(String apellido1) {
		this.apellido1 = apellido1;
	}

	public String getApellido2() {
		return apellido2;
	}

	public void setApellido2(String apellido2) {
		this.apellido2 = apellido2;
	}

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}
	
}
