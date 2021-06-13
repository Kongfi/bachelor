const routes = [
  {
    path: "",
    component: () => import("src/layouts/indexLayout.vue"),
    children: [
      {
        path: "",
        name: "Index",
        component: () => import("src/pages/index.vue")
      }
    ]
  },
  {
    path: "",
    component: () => import("src/layouts/mainLayout.vue"),
    children: [
      {
        path: "/form",
        name: "Form",
        component: () => import("src/pages/form.vue")
      },
      {
        path: "/profil",
        name: "Profile",
        component: () => import("src/pages/profile.vue")
      },
      {
        path: "/success",
        name: "Success",
        component: () => import("src/pages/succesPage.vue")
      }
    ]
  },

  // Always leave this as last one,
  // but you can also remove it
  {
    path: "*",
    component: () => import("src/pages/error404.vue")
  }
];

export default routes;
