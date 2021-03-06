#version 130

varying vec2 texcoord;

uniform sampler2D tex;

void main()
{
    vec4 t, s;

    t = texture(tex, texcoord);

    if (t.a < 0.5)
        discard;
    
    gl_FragColor = vec4(1.0);
}
