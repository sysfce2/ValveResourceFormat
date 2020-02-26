using System;
using System.Collections.Generic;
using System.Numerics;

namespace GUI.Types.ParticleRenderer.Renderers
{
    public interface IParticleRenderer
    {
        void Render(ParticleBag particles, Matrix4x4 projectionMatrix, Matrix4x4 modelViewMatrix);
    }
}
