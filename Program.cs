// dotnet add package pythonnet
using Python.Runtime;

// python --version
Runtime.PythonDLL = "python311.dll";
PythonEngine.Initialize();

dynamic tf = Py.Import("tensorflow");
dynamic np = Py.Import("numpy");

dynamic model = tf.keras.models.load_model("checkpoints/98-86.keras");

// pip install pillow
dynamic list = new PyList();
// list.append(tf.keras.utils.load_img("tests/atores/tomCruise.png"));
// list.append(tf.keras.utils.load_img("tests/atores/will.png"));
list.append(tf.keras.utils.load_img("tests/sala/felipe.png"));
// list.append(tf.keras.utils.load_img("tests/sala/vini.png"));

dynamic data = np.array(list); 
dynamic result = model.predict(data);

Console.WriteLine(result);
PythonEngine.Shutdown();