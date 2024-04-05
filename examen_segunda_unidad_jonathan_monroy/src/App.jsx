import { useState } from 'react'

function App() {
  const [count, setCount] = useState(0)

  const [ name, setName ] = useState('')
  const [ genre, setGenre ] = useState('')
  const [ weight, setWeight ] = useState('')
  const [ height, setHeight ] = useState('')

  const [ people, setPeople ] = useState([])

  const handleSubmit = (e) => {

    e.preventDefault();

    console.log(name);
    console.log(genre);
    console.log(weight);
    console.log(height);

    const meter = height/100

    const sq = meter * meter

    const imc = weight/sq

    console.log(imc)

    if (imc <= 18.5) {
      
      console.log('Bajo Peso');

    }else if (18.5 < imc <= 24.9 ) {
      
      console.log('Peso Normal');

    }else if (25.0 < imc <= 29.9 ) {
      
      console.log('Sobrepeso');

    }else if (30.0 < imc <= 34.9 ) {
      
      console.log('Obesidad Grado I');

    }else if (35.0 < imc <= 39.9 ) {
      
      console.log('Obesidad Grado II');

    }else if (imc > 40.0) {
      
      console.log('Obesidad Grado III');

    }
    
  }


  const addPatient = () => {

    

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
