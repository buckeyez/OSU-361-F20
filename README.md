# Expert Finder

## OSU-361-F20 Group 10 Project

### Members

- Clifford (Mason) Reiselt
- Dylan Bodvig
- Nam Nguyen
- Gagandeep Singh
- Abraham Almahmoud

## Prerequisites

- nodejs LTS (https://nodejs.org/en/download/)
- dotnet core 3.1 SDK (https://dotnet.microsoft.com/download/dotnet-core/3.1)

## Development Prerequisites

- eslint: `npm i --global eslint`
- dotnet entity frame work tool
  - after installing sdk run: `dotnet tool install --global dotnet-ef`
- VS Code with the following extensions added:
  - Debugger for Chrome (or browser of choice)
  - Prettier
  - EditorConfig
  - C#
  - ESLint
  - language-stylus
  - Sass
  - Vetur
  - Optional:
    - Code Spell Checker
    - Spell Right
    - SQLTools (if you want to open the db for browsing)
    - SQLTools SQLite (plugin needed to open sqlite for the above ext)

## Running

### Setting Up Environment

- install node packages: `npm install` in project root folder
- restore dotnet packages: `dotnet restore` in project root folder

### Running Server

- `dotnet run` will kick off the server and allow you to connect with a browser to http://localhost:8080/

## Development

### Vue

Most all of the development from this point on will be done in Vue. Vue is a single page app (SPA) that is an in-between of React and Angular. The documentation for Vue is really good and for the most part everything can be figured out by looking at the docs (https://vuejs.org/v2/guide/).

For the most part, you will be designing your own components that will be added to the project. The Vue / client files will exist in the `Client-App` folder. Relatively speaking, modifications to the `App.vue` should be very minimal (i.e. - just to add your component and be able to view it).

When you create a new component, please add a new ___folder___ in the `Client-App` folder to separate your work.

An example of how a Vue component is structured can be found in the `example` folder. For now, when you create a component, add it to the `App.vue` as you see for the example. Add a bool to the data for displaying yours, and ensure to set the example bool to false. Also, add the additional bool to the `computed` method that is used for the placeholder (Hello World text).

### Styling

There is a css reset done on the top level Vue `App.vue` component, so it will be treated as the source of truth versus using browser specifics. For the most part, this does not concern you. There is a `app-styles.css` file in client folder `assets/css`, any html elements (h1, h2, etc.) that need to be added, should be done here.

Any individual style classes for Vue components should be handled in the `<style>` tags of that component. Please follow the Block Element Modifier naming convention, found here http://getbem.com/naming/. This will help prevent any possible name collisions.

An example of how styling should be done in individual components can be found in the `ExampleComponent.vue` Vue component.

### Axios

Requesting information from the server/database will be done with Axios. It is already apart of the project, but still needs to be imported on the individual Vue components inside the `<script>` tags, above the Vue export.

For this to work the appropriate path must exist on the server. The paths are handled by the `Controllers`. Access to the database is handled via `Repositories`. Please take some time to look through them and familiarize yourself with how the work. Once a route is in place, you just point axios at it (e.g. - `Axios.Get('/user/mason')..`).

An example of how this works can be found in the `ExampleComponent.vue` Vue component. We will be following the REST API convention (https://restfulapi.net/). Basically, that just boils down to using `GET`, `POST`, `PUT`, etc.

### Models

Models represent our data and is used to build the database. If a new table is needed, in most situations a new Model is needed. If you need help with this, please ask. If updates are made you must do the following for the db to represent the changes:

- Ensure server is not running, then...
- `dotnet ef migrations add <name/short description (no white spaces)>`
- `dotnet ef database update`
- then you will have to re-run the server `dotnet run`

### Repositories

Repositories, as mentioned above in the Axios section, are used to access the database (i.e. - they contain our queries). By separating it from the controllers, it will help with testing. Please take some time to examine the current implementation.

### Controllers

Controllers provide routing for the server. For the most part, they will just call their corresponding repository methods. You specify the routes with the attribute tag `[Route("<path>")]`. Please take some time to review how these are currently done.

### Dummy Data

Want to add some dummy data to the database for testing and viewing? Use the `DummyData.cs` static class to handle this. There is an example there already, this part should be relatively straight forward.

## Known Issues

When killing the server `ctrl + c` in the console that is running `dotnet`, it may spit out the following:

```text
Application is shutting down...
Unhandled exception. System.OperationCanceledException: The operation was canceled.
   at System.Threading.CancellationToken.ThrowOperationCanceledException()
   at Microsoft.Extensions.Hosting.Internal.Host.StopAsync(CancellationToken cancellationToken)
   at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.WaitForShutdownAsync(IHost host, CancellationToken token)
   at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
   at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
   at ExpertFinder.Program.Main(String[] args) in /home/buckeyez/ExpertFinder/Program.cs:line 23
   at ExpertFinder.Program.<Main>(String[] args)
```

I attempted to resolve this, but it may still occur. There really is no harm in it, and is not something to really be concerned with for now.
