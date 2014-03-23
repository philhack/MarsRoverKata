using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain
{
    public abstract class BaseDirection {
        protected IPlanetSurface PlanetSurface;

        protected BaseDirection(IPlanetSurface planetSurface) {
            PlanetSurface = planetSurface;
        }
    }
}
