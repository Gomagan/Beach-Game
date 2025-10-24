README file 
Project name: Beach Game 

By: 	Kishan Mohanakanth (100921637) 
Gomagan Prabagar (100944940)

Youtube Video Link: https://www.youtube.com/watch?v=cVFZXgi9QMs

Base: Beach game is a simple and relaxing hide and seek game, where players are stranded on an island and need to find a series of items to win the game. Items in this game are randomized and failure to find the items on time results in losing the game. For players that want to relax there is a free roam mode letting players appreciate the shaders, 3D models, lighting and detail. This game is built in Unity 6 with 3d models made in blender and textured in substance painter. All shaders in this project/game are made using shader graph and shader code focusing on stylized, color grading, and environmental immersion. 

The following shaders are implemented in this game: 

Ambient Lighting Shader:  attached to the coin, This shader simulates global lighting in the environment. Ambient light is basically background light that hits all surfaces evenly. It simulates light bouncing from walls, floors, and other surfaces. This ensures that shaded parts aren’t completely dark. It provides a base layer of light for all materials in game. 
Formula: surface albedo * ambient light color * ambient light intensity
Surface Albedo: How much light the material reflects overall
Ambient light color: The color of the light
Ambient light intensity: How strong the overall background light is
Specular Lighting Shader: attached to the coin, Specular simulates how light reflects sharply in smooth surfaces creating bright highlights like what we see in metal, glass, or wet materials. In this shader we use diffuse lighting and it spreads evenly in all directions. Specular lighting focuses on light reflection towards the viewer based on the angle. A high shininess will give you a small highlight like in metal. And a low shininess gives you a larger highlight like for skin or plastic. This shader is good for making shiny or reflective objects. 
Formula : Specular Light = C x L (max(0,N.H))^S

C = Specular color (color of the highlight)
L = light intensity 
N = normal direction on the surface 
H = Half vector between the light and view direction
S = controls how sharp or soft the highlight is 

Ambient + Specular Shader: attached to the coin, This shader combines ambient light and specular highlights to produce a natural looking illumination. Ambient lighting makes sure that surfaces are softly lit while the specular reflections give depth and realism to shiny materials. This is useful for objects that transition from lit to shadowed. 
Formula : (surface albedo * ambient light color * ambient light intensity) + C x L (max(0,N.H))^S

Lambert + Rim Glow:  attached to the coin, Lambert + Rim Glow combines two lighting models: lambertian diffuse lighting and rim lighting glow to create a realistic lighting and a striking appearance. Lambert shows how the angle of light diffuses across a surface. The Rim glow effect is to make the object strike and visually stand out along its edges. The result is a natural under light that gives out stylized energy, perfect for character models, magic objects or any highlighted objects
Formula: C x L x max(0, N.L) +  (RimColor x (1-max(0,N.V)^power) 

Color Grading: changes the mood and tone of the scene. We implemented them using LUTs (Look-Up Tables) to remap colors based on saturation, contrast, hue and brightness. Each LUT corresponds to a specific visual mood. 
Warm tint (Sunshine): For the Sunshine grading we went for a more brighter and warmer tone using colors like yellow, orange and higher contrast. 
Cool tint (Sunset): A cooler and darker tone for night time using cooler colors like blue and darker tinted colors. 
Black and White tint (Monochromatic): monochrome or black and white, for this grading we went for a black and white as a custom grading shader. This is used only to focus on luminance how bright or how dark each pixel is 

Toon Shader: Toon shading is added on the crab object in the game. The toon shader or otherwise called as cel shader renders 3d objects non photorealistic making the graphics look flat. Toon shading uses flat colouring toon bands instead of smooth gradients, creating a flat stylized color effect similar to what we see in anime or comic art. This shader gives 3D objects an emphasized silhouette. This shader works with games that feel dynamic and ideal for stylized or hand painted aesthetics.

Water Shader: The water shader is attached to the plane surrounding the island. This shader combines bump mapping and vertex displacement to simulate the wave motion. The bump mapping brings the illusion of ripples and small waves, while vertex animation makes the water surface move dynamically. 

Bump and Normal Mapping: Bump mapping is applied to the gold bar. It uses grayscale texture to fake bumps, indents, and roughness by slightly changing how light interacts with the surface. White areas show that the texture will be bumped up and dark areas show that the texture will be indented. This brings an illusion to the object without changing the geometry of the mesh. Normal mapping is applied to the rock. It uses a normal map to bring realistic lighting and shadows making the mesh look like it has more geometry even though it doesn’t. 

Rim Lighting:  Rim lighting attached to the ball. Rim Lighting shaders give edge highlights of an object based on the camera view angle. This shader creates a soft glow and a silhouette emphasizing the shape and giving the object a separation from the background. This can be used to create cinematic and stylized lighting effects trying to make objects appear visually. 
