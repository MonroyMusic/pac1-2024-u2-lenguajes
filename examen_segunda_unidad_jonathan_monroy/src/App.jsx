import { useState } from 'react'

function App() {
  const [count, setCount] = useState(0)

  const [ name, setName ] = useState('')
  const [ genre, setGenre ] = useState('')
  const [ weight, setWeight ] = useState('')
  const [ height, setHeight ] = useState('')

  const [ people, setPeople ] = useState([])

  const handleSubmit = (e) => {    
    
    addPatient();

  }


  const addPatient = async () => {

    try {
      
      const response = await fetch('https://localhost:7275/api/patients',
    
      {

        method: 'POST',

        headers: {

          'Content-Type': 'application/json'

        },

        body: JSON.stringify(people)

      });

      if (!response.ok) {
        
        throw new Error('Error al agregar al paciente')

      }

      setName({... people, name:''})
      setWeight({... people, weight:''})
      setHeight({... people, height:''})
      
    } catch (error) {
      
      console.error(error);

    }

  }

  return (
    <div>

      <div>

        <div className="container">
          <h2>Calculadora de IMC</h2>
          <form onSubmit={handleSubmit} id="imcForm">
            <div>
              <label>Nombre:</label>
              <input type="text" id="nombre" name="nombre" required onChange={ (e) => setName(e.target.value) } />
            </div>
            <div>
              <label>Género:</label>
              <select id="genero" name="genero" required onChange={ (e) => setGenre(e.target.value) } >
                <option value="" >Seleccione Género</option>
                <option value="masculino" >Masculino</option>
                <option value="femenino">Femenino</option>
              </select>
            </div>
            <div>
              <label>Peso (kg):</label>
              <input type="number" id="peso" name="peso" required onChange={ (e) => setWeight(e.target.value) } />
            </div>
            <div>
              <label>Altura (cm):</label>
              <input type="number" id="altura" name="altura" required onChange={ (e) => setHeight(e.target.value) }/>
            </div>
            <button type="submit">Calcular IMC</button>
          </form>
          <div id="resultado"></div>
        </div>

        <script src="script.js"></script>

      </div>

    </div>
  )
}

export default App
