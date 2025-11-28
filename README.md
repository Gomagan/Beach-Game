README file 

Updated on (2025-11-28) (for the Course Project)
Project name: Beach Game 

By: 	Kishan Mohanakanth (100921637) 
Gomagan Prabagar (100944940)

Youtube Video Link: https://youtu.be/QYuaaJojw70 

Overview: Since our last presentation, we made several major changes to our beach game and the overall look and tone of the project has changed dramatically. Previously the atmosphere of the game felt bland and slightly depressive even though you are stranded on an island, but the environment felt empty and we felt that it didn't match the visual style. So we decided to enhance the visuals of the game and push it towards a stylized and vibrant aesthetic. 
Environment Updates: one of the biggest changes we have done to the environment of the Beach game is replacing all the old rock models with brand new stylized versions. The previous rock lacked life, and color. We made sure the shapes, color and silhouettes fit the stylized beach game more consistently. Another thing to note is that we added mesa mountains around the scene, this helps cover up all the blank space and it prevents the player from not feeling that they are playing in a void. To reinforce the art style we implemented toon shader to the mesa cliffs to bring contrast, bold colours, and enhance the handpainted textures. 
New assets and texture updates: Assets that are newly modeled and textured are the sand ground, rocks, rocketship, barrel, boat, campfire, palm tree, mesa mountain, hologram projector and hologram character. Some texture changes are that we made the palm trees more saturated, more stylized so that it's more cohesive with the rest of the island. We also upgraded the sand ground by texturing it in blender while we were texturing it. We made sure to add some bumps and dents so that it will pop out once we add the normal mapping shader. 

Textures: For our 3D models we made a mandatory texture choice to support the stylized look of the beach game. Instead of using realistic textures or high detailed textures we focused on making simple shapes, softer gradients, bold colours, and clean surface detail so that everything feels visually appealing. All our textures were painted and baked in substance painter where we avoided using heavy realistic grunge, roughness. For example the palm trees and coconuts were retextured with brighter greens and warmer browns so that they would look  more lively to match the game's sunny and vibrant tone. The rocks are also redesigned with smoother color transitions and stylized edge highlights to complement both normal mapping and lambert shading. Even our new assets like the new sand ground, rocketship, and hologram project use simplified and readable textures that pop with the environment. We’ve used scrolling textures for many of the visual effects in the game. For example, the water shader scrolls two normal maps towards each other at different speeds to create a moving wave effect. We also made some clouds using noise and scrolled them to create the moving clouds effect. One more thing we’ve used scrolling textures for are the effects on some of the wooden surfaces. There are words saying “consume” scrolling over these wooden surfaces but their original textures stay in place. This effect is supposed to represent danger in these objects and basically tells the player to stay away from them. 

Hologram Shader: For our first stylized visual effect we made a hologram shader made in a shader graph and it is applied to our dancing character model. This shader uses techniques like rim lighting, scanlines, transparency and color tinting. The goal for this shader is to bring a sci-fi kick into our game making the character glow, appear like a digital projection and glitch like a hologram. Just like how we used a Toon band to make toon shading we used a hologram band to make the special line effects on the model. Below is the formula for the hologram shader. 

Glass Shader: For the glass shader we made this in a shader graph, this shader uses several adjustable properties that controls how the glass behaves. Our approach for this glass is to make it stylized and look shattered or broken. The metallic and smoothness simulates how shiny or how reflective the glass would be. The reflection strength shows how much you want your glass to reflect from the environment. Next we have the noise strength, normal strength, and distortion strength. The noise adds irregularities, the normal simulates the bumps, and the distortion warps the background slightly. And Finally the glass color which gives the glass a tint making it clear.

Campfire Shader/Particle Effect: For the campfire in our game we created a stylized fire effect by building two custom shaders using shader graphs and then combining them into particle systems. The first shader generates the main flames by using scrolling noise and masking the flame image which makes the flames appear and rise upwards. The second fire shader is the glow layer, it uses additive blending and a stronger distortion pattern so that the bright parts of the flame can emit light and glow in the environment. When we set up the particle system we applied both shaders and we set it as when the fire fades out at the top just like real fire. We made the flames colours by blending warm colors in the gradient ramp so that it gives the flame a smooth and soft transition you’d see in a campfire. 

Scrolling Water: Last time, for the water shader, we modified each vertex over time. This time, we’ve improved upon this shader by also adding scrolling to it. We scrolled two normal textures towards each other, one slower than the other to create this new effect. How this works is by changing the offset of tiling and offset node overtime. Since there are two normal textures scrolling against each other, the divide and one-minus node is used to slow and flip the other texture so that they scroll towards each other at different speeds. These two textures are then added and given in as the normal texture into the fragment shader.

Shadows shader: We’ve added self shadows to some of the gameobjects. How it works is by getting the dot product between the main light direction and the normal world vector. It then flips the output with the one-minus node (because without it, shadows are applied where light hits) and smooths it out with the smoothstep node. It is then multiplied by the base texture and given into the base color of the fragment shader. 

Clouds shader: This is a relatively simple shader. The clouds use a scrolling texture on a plane. It uses simple noise and scrolls it over time using the tiling and offset node. It is then given into the Base Color of the fragment shader. The power and multiply nodes are used to set up the clouds to look how we want. 

Decal shader: The decal shader is when a texture is applied along with another texture. In these cases, the words “consume” is applied to the base textures of these gameobjects. Additionally, we’ve also applied scrolling to these textures to give them more of an ominous effect. In this case, a virus from the rocket is spreading to nearby wooden surfaces.














------------------------------------------------------------------------------------------------------------------------------------------


(Previous Version for the project progression)

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
