using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position currentPosition; // posicion actual
        Position initialPosition; // posicion inicial
        Position finalPosition; // posicion final
        double velocidad;

        // Constructures
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.currentPosition = new Position(cpx, cpy);
            this.initialPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }

        // Metodos
        public void SetVelocidad(double velocidad)
        // setter del atributo velocidad
        { this.velocidad = velocidad; }

        public void SetId(string id)
        // setter del atributo id
        { this.id = id; }

        public void SetCurrentPosition(Position position)
        // setter del atributo currentPosition
        { this.currentPosition = position; }

        public void SetFinalPosition(Position position)
        // setter del atributo finalPosition
        { this.finalPosition = position; }

        public double GetVelocidad()
        // getter del atributo velocidad
        { return this.velocidad; }

        public string GetId()
        // getter del atributo id
        { return this.id; }

        public Position GetCurrentPosition()
        // getter del atributo currentPosition
        { return this.currentPosition; }

        public Position GetFinalPosition()
        // getter del atributo finalPosition
        { return this.finalPosition; }

        public Position GetInitialPosition()
        // getter del atributo initialPosition
        { return this.initialPosition; }


        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60;

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno;
            double y = currentPosition.GetY() + distancia * seno;

            Position nextPosition = new Position(x, y);

            // Modificar MoverVuelo para que no se pase del destino
            if (currentPosition.Distancia(nextPosition) < hipotenusa)
                currentPosition = nextPosition;
            else
                currentPosition = finalPosition;

        }

        // Hacer un metodo que diga si un vuelo ha llegado a su destino
        public bool EstaDestino()
        {
            bool resultado = false;
            if (currentPosition == finalPosition)
                resultado = true;

            return resultado;
        }

        // Hacer que el programa principal lea datos de dos vuelos y una distancia de seguidad y detecte el conflicto cuándo los vuelos están mas cerca de esa distancia
        public bool Conflicto(FlightPlan b, double distanciaSeguridad)
        {
            bool conclicto = false;

            if (this.currentPosition.Distancia(b.currentPosition) < distanciaSeguridad)
                conclicto = true;

            return conclicto;
        }

        public void EscribeConsola()
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0}", id);
            Console.WriteLine("Velocidad: {0:F2}", velocidad);
            Console.WriteLine("Posición actual: ({0:F2}, {1:F2})", currentPosition.GetX(), currentPosition.GetY());
            if (this.EstaDestino())
                Console.WriteLine("Ha llegado al destino");
            Console.WriteLine("******************************");
        }

        public void Restart()
        // Devuelve la posición actual a la posición inicial proporcionada en el constructor
        {
            // Restauramos una copia de la posición inicial para evitar aliasing
            this.currentPosition = new Position(this.initialPosition.GetX(), this.initialPosition.GetY());
        }
        public double Distancia(FlightPlan f)
        // retorna la distancia entre los dos Postion
        {
            double resultado = Math.Sqrt(Math.Pow(this.currentPosition.GetX() - f.currentPosition.GetX(), 2) + Math.Pow(this.currentPosition.GetY() - f.currentPosition.GetY(), 2));
            return resultado;
        }
    }
}